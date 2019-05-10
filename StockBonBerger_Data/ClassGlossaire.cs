using ManageUtilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace StockBonBerger_Data
{
    public class Glossaire
    {
        const string DirectoryLog = "Log";
        private static string _connectionString, _host, _db, _user, _pwd;
        private static Glossaire glos;
        private SqlConnection sqlCon;
        public static string currentDB;

        #region Prerequisite

        public static Glossaire GetInstance()
        {
            if (glos == null)
            {
                glos = new Glossaire();
            }
            return glos;
        }

        private static void SetParameter(SqlCommand cmd, string name, DbType type, int length, object paramValue)
        {

            IDbDataParameter a = cmd.CreateParameter();
            a.ParameterName = name;
            a.Size = length;
            a.DbType = type;

            if (paramValue == null)
            {
                if (!a.IsNullable)
                {
                    a.DbType = DbType.String;
                }
                a.Value = DBNull.Value;
            }
            else
                a.Value = paramValue;

            cmd.Parameters.Add(a);
        }

        private object GetParameter(IDbCommand cmd, string name, DbType type, int size, object value)
        {
            IDbDataParameter param = cmd.CreateParameter();
            param.Size = size;
            param.DbType = type;
            param.ParameterName = name;
            param.Value = value;
            return param;
        }

        public void Initilize(Connexion con)
        {
            _host = con.Server;
            _db = con.Database;
            _user = con.User;
            _pwd = con.Password;

            string path = string.Format("server={0}; database={1}; user={2}; pwd={3}", _host, _db, _user, _pwd);
            StockBonBerger_Data.Properties.Settings.Default.ConnectionString = path;
            sqlCon = new SqlConnection(path);
        }

        public void SetDatabase(string db)
        {
            _db = db;
        }

        public bool IsConnected()
        {
            bool connected = true;
            try
            {
                if (sqlCon.State != ConnectionState.Open) sqlCon.Open();
                sqlCon.Close();
            }
            catch (Exception exc)
            {
                connected = false;
                sqlCon.Close();
                string MasterDirectory = ImplementUtilities.Instance.MasterDirectoryConfiguration;
                ImplementLog.Instance.PutLogMessage(MasterDirectory, DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + " : Etat de la connexion à la BD sans paramètre : " + exc.Message, DirectoryLog, MasterDirectory + "LogFile.txt");
                throw new Exception(exc.Message);
            }
            return connected;
        }

        public void CloseConnexion()
        {
            try
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            catch (Exception) { }
        }

        public List<string> GetAllDatabase()
        {
            List<string> lst = new List<string>();

            try
            {
                if (sqlCon.State != ConnectionState.Open) sqlCon.Open();

                using (IDbCommand cmd = sqlCon.CreateCommand())
                {
                    cmd.CommandText = string.Format("SELECT name FROM sysdatabases WHERE name != 'master' ORDER BY name");
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                            lst.Add(dr["name"].ToString());
                    }
                    sqlCon.Close();
                }
            }
            catch (Exception exc)
            {
                sqlCon.Close();
                string MasterDirectory = ImplementUtilities.Instance.MasterDirectoryConfiguration;
                ImplementLog.Instance.PutLogMessage(MasterDirectory, DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + " : Récupération de toutes les bases de Données SQLServer : " + exc.Message, DirectoryLog, MasterDirectory + "LogFile.txt");
                throw new Exception(exc.Message);
            }
            return lst;
        }

        public string GetCurrentDatabase()
        {
            string bd = "";

            try
            {
                if (sqlCon.State != ConnectionState.Open) sqlCon.Open();

                using (IDbCommand cmd = sqlCon.CreateCommand())
                {
                    cmd.CommandText = string.Format("SELECT DB_NAME() AS bd_encours");
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            bd = (dr["bd_encours"].ToString());
                        }
                    }
                    sqlCon.Close();
                }
            }
            catch (Exception exc)
            {
                sqlCon.Close();
                string MasterDirectory = ImplementUtilities.Instance.MasterDirectoryConfiguration;
                ImplementLog.Instance.PutLogMessage(MasterDirectory, DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + " : Récupération de toutes les bases de Données SQLServer : " + exc.Message, DirectoryLog, MasterDirectory + "LogFile.txt");
                throw new Exception(exc.Message);
            }
            return bd;
        }

        #endregion

        #region Gestion des droits d'accès sur les tables

        public List<int> GetDroitsUser(int idUser)
        {
            List<int> droits = new List<int>();

            try
            {
                if (sqlCon.State != ConnectionState.Open) sqlCon.Open();

                using (IDbCommand cmd = sqlCon.CreateCommand())
                {
                    cmd.CommandText = string.Format("SELECT droits FROM " + Constants.Table.UTILISATEUR + " WHERE id =" + idUser);
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            string[] temp = dr["droits"].ToString().Split(',');
                            int taille = temp.Length;

                            foreach (string str in temp)
                            {
                                if (str.ToString().Equals("SysAdmin")) droits.Add(0);
                                else if (str.Equals("Admin")) droits.Add(1);
                                else if (str.Equals("User")) droits.Add(2);
                            }
                        }
                    }
                }
                sqlCon.Close();
            }
            catch (Exception exc)
            {
                sqlCon.Close();
                string MasterDirectory = ImplementUtilities.Instance.MasterDirectoryConfiguration;
                ImplementLog.Instance.PutLogMessage(MasterDirectory, DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + "Attribution de droits de manipulation sur les tables : " + exc.Message, DirectoryLog, MasterDirectory + "LogFile.txt");
                throw new Exception(exc.Message);
            }
            return droits;
        }

        public void GrantPermission(List<int> permission, string loginName, string username)
        {
            try
            {
                if (sqlCon.State != ConnectionState.Open) sqlCon.Open();
 
                foreach (int droit in permission)
                {
                    if (droit == 0)
                    {
                        // Les droits pour le super administrateur de la base des données

                        string query = @"EXEC sp_addsrvrolemember '" + loginName + @"','SysAdmin' 
                            EXEC sp_addsrvrolemember '" + loginName + @"','Admin' 
                            EXEC sp_addrolemember 'db_owner','" + username + @"'
                            EXEC sp_addrolemember 'db_accessadmin','" + username + @"'";

                        using (IDbCommand cmd = sqlCon.CreateCommand())
                        {
                            cmd.CommandText = string.Format(query);
                            cmd.ExecuteNonQuery();
                        }                       
                    }
                    else if (droit == 1)
                    {
                        // Les droits pour l'administrateur (Il ne peut pas effectuer la suppression sur le table)

                        string query = @"GRANT SELECT, INSERT, UPDATE ON " + Constants.Table.APPROVISIONNEMENT + " TO " + username + @" 
                            GRANT SELECT, INSERT, UPDATE ON " + Constants.Table.CATEGORIE_CLIENT + " TO " + username + @" 
                            GRANT SELECT, INSERT, UPDATE ON " + Constants.Table.CATEGORIE_PIECE + " TO " + username + @" 
                            GRANT SELECT, INSERT, UPDATE ON " + Constants.Table.CLIENT + " TO " + username + @" 
                            GRANT SELECT, INSERT, UPDATE ON " + Constants.Table.COMMANDE + " TO " + username + @" 
                            GRANT SELECT, INSERT, UPDATE ON " + Constants.Table.DETAIL_APPROVISIONNEMENT + " TO " + username + @" 
                            GRANT SELECT, INSERT, UPDATE ON " + Constants.Table.DETAIL_COMMANDE + " TO " + username + @" 
                            GRANT SELECT, INSERT, UPDATE ON " + Constants.Table.DETAIL_VENTE + " TO " + username + @" 
                            GRANT SELECT, INSERT, UPDATE ON " + Constants.Table.FOURNISSEUR + " TO " + username + @" 
                            GRANT SELECT, INSERT, UPDATE ON " + Constants.Table.MODE_PAIEMENT + " TO " + username + @" 
                            GRANT SELECT, INSERT, UPDATE ON " + Constants.Table.PAIEMENT + "" + username + @" 
                            GRANT SELECT, INSERT, UPDATE ON " + Constants.Table.UTILISATEUR + " TO " + username + @" 
                            GRANT SELECT, INSERT, UPDATE ON " + Constants.Table.VENTE + " TO " + username;

                        using (IDbCommand cmd1 = sqlCon.CreateCommand())
                        {
                            cmd1.CommandText = string.Format(query);
                            cmd1.ExecuteNonQuery();
                        }
                    }
                    else if (droit == 2)
                    {
                        // Les droits pour les utilisateurs simple de l'application

                        string query = @"GRANT SELECT, INSERT, UPDATE ON " + Constants.Table.APPROVISIONNEMENT + " TO " + username + @" 
                            GRANT SELECT, INSERT, UPDATE ON " + Constants.Table.CATEGORIE_CLIENT + " TO " + username + @" 
                            GRANT SELECT, INSERT, UPDATE ON " + Constants.Table.CATEGORIE_PIECE + " TO " + username + @" 
                            GRANT SELECT, INSERT, UPDATE ON " + Constants.Table.CLIENT + " TO " + username + @" 
                            GRANT SELECT, INSERT, UPDATE ON " + Constants.Table.COMMANDE + " TO " + username + @" 
                            GRANT SELECT, INSERT, UPDATE ON " + Constants.Table.DETAIL_APPROVISIONNEMENT + " TO " + username + @" 
                            GRANT SELECT, INSERT, UPDATE ON " + Constants.Table.DETAIL_COMMANDE + " TO " + username + @" 
                            GRANT SELECT, INSERT, UPDATE ON " + Constants.Table.DETAIL_VENTE + " TO " + username + @" 
                            GRANT SELECT, INSERT, UPDATE ON " + Constants.Table.FOURNISSEUR + " TO " + username + @" 
                            GRANT SELECT ON " + Constants.Table.MODE_PAIEMENT + " TO " + username + @" 
                            GRANT SELECT, INSERT, UPDATE ON " + Constants.Table.PAIEMENT + "" + username + @" 
                            GRANT SELECT ON " + Constants.Table.UTILISATEUR + " TO " + username + @" 
                            GRANT SELECT, INSERT, UPDATE ON " + Constants.Table.VENTE + " TO " + username;

                        using (IDbCommand cmd2 = sqlCon.CreateCommand())
                        {
                            cmd2.CommandText = string.Format(query);
                            cmd2.ExecuteNonQuery();
                        }
                    }
                }
                sqlCon.Close();
            }
            catch (Exception exc)
            {
                sqlCon.Close();
                string MasterDirectory = ImplementUtilities.Instance.MasterDirectoryConfiguration;
                ImplementLog.Instance.PutLogMessage(MasterDirectory, DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + " : Echec d'attribution des droits à l'utilisateur, veuillez réessayez ultérieurement : " + exc.Message, DirectoryLog, MasterDirectory + "LogFile.txt");
                throw new Exception(exc.Message);
            }
        }

        public void RevokePermission(List<int> permission, string loginName, string username)
        {
            try
            {
                if (sqlCon.State != ConnectionState.Open) sqlCon.Open();

                foreach (int droit in permission)
                {
                    if (droit == 0)
                    {
                        throw new Exception("Les droits de l'administrateur ne peuvent pas être retirés à ce niveau, reportez vous au moteur de SGBD");
                    }
                    else if (droit == 1)
                    {
                        // Suppression des droits pour l'administrateur (Il ne peut pas effectuer la suppression sur le table)

                        string query = @"GRANT SELECT, INSERT, UPDATE ON " + Constants.Table.APPROVISIONNEMENT + " TO " + username + @" 
                            REVOKE SELECT, INSERT, UPDATE ON " + Constants.Table.CATEGORIE_CLIENT + " TO " + username + @" 
                            REVOKE SELECT, INSERT, UPDATE ON " + Constants.Table.CATEGORIE_PIECE + " TO " + username + @" 
                            REVOKE SELECT, INSERT, UPDATE ON " + Constants.Table.CLIENT + " TO " + username + @" 
                            REVOKE SELECT, INSERT, UPDATE ON " + Constants.Table.COMMANDE + " TO " + username + @" 
                            REVOKE SELECT, INSERT, UPDATE ON " + Constants.Table.DETAIL_APPROVISIONNEMENT + " TO " + username + @" 
                            REVOKE SELECT, INSERT, UPDATE ON " + Constants.Table.DETAIL_COMMANDE + " TO " + username + @" 
                            REVOKE SELECT, INSERT, UPDATE ON " + Constants.Table.DETAIL_VENTE + " TO " + username + @" 
                            REVOKE SELECT, INSERT, UPDATE ON " + Constants.Table.FOURNISSEUR + " TO " + username + @" 
                            REVOKE SELECT, INSERT, UPDATE ON " + Constants.Table.MODE_PAIEMENT + " TO " + username + @" 
                            REVOKE SELECT, INSERT, UPDATE ON " + Constants.Table.PAIEMENT + "" + username + @" 
                            REVOKE SELECT, INSERT, UPDATE ON " + Constants.Table.UTILISATEUR + " TO " + username + @" 
                            REVOKE SELECT, INSERT, UPDATE ON " + Constants.Table.VENTE + " TO " + username;

                        using (IDbCommand cmd1 = sqlCon.CreateCommand())
                        {
                            cmd1.CommandText = string.Format(query);
                            cmd1.ExecuteNonQuery();
                        }
                    }
                    else if (droit == 2)
                    {
                        string query = @"REVOKE SELECT, INSERT, UPDATE ON " + Constants.Table.APPROVISIONNEMENT + " TO " + username + @" 
                            REVOKE SELECT, INSERT, UPDATE ON " + Constants.Table.CATEGORIE_CLIENT + " TO " + username + @" 
                            REVOKE SELECT, INSERT, UPDATE ON " + Constants.Table.CATEGORIE_PIECE + " TO " + username + @" 
                            REVOKE SELECT, INSERT, UPDATE ON " + Constants.Table.CLIENT + " TO " + username + @" 
                            REVOKE SELECT, INSERT, UPDATE ON " + Constants.Table.COMMANDE + " TO " + username + @" 
                            REVOKE SELECT, INSERT, UPDATE ON " + Constants.Table.DETAIL_APPROVISIONNEMENT + " TO " + username + @" 
                            REVOKE SELECT, INSERT, UPDATE ON " + Constants.Table.DETAIL_COMMANDE + " TO " + username + @" 
                            REVOKE SELECT, INSERT, UPDATE ON " + Constants.Table.DETAIL_VENTE + " TO " + username + @" 
                            REVOKE SELECT, INSERT, UPDATE ON " + Constants.Table.FOURNISSEUR + " TO " + username + @" 
                            REVOKE SELECT ON " + Constants.Table.MODE_PAIEMENT + " TO " + username + @" 
                            REVOKE SELECT, INSERT, UPDATE ON " + Constants.Table.PAIEMENT + "" + username + @" 
                            REVOKE SELECT ON " + Constants.Table.UTILISATEUR + " TO " + username + @" 
                            REVOKE SELECT, INSERT, UPDATE ON " + Constants.Table.VENTE + " TO " + username;

                        using (IDbCommand cmd2 = sqlCon.CreateCommand())
                        {
                            cmd2.CommandText = string.Format(query);
                            cmd2.ExecuteNonQuery();
                        }
                    }
                }
                sqlCon.Close();
            }
            catch (Exception exc)
            {
                sqlCon.Close();
                string MasterDirectory = ImplementUtilities.Instance.MasterDirectoryConfiguration;
                ImplementLog.Instance.PutLogMessage(MasterDirectory, DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + " : Echec retrait des droits à l'utilisateur, veuillez réessayez ultérieurement : " + exc.Message, DirectoryLog, MasterDirectory + "LogFile.txt");
                throw new Exception(exc.Message);
            }
        }
        #endregion
    }
}
