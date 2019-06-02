using DevExpress.XtraGrid;
using ManageUtilities;
using StockBonBerger_Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace StockBonBerger_Data
{
    public class Glossaire
    {
        const string DirectoryLog = "Log";
        private static string _connectionString, _host, _db, _user, _pwd;
        private static Glossaire glos;
        private SqlDataAdapter adapter; 
        private SqlConnection sqlCon;
        public static string currentDB;

        #region Prerequisite

        public static Glossaire Instance
        {
            get
            {
                if (glos == null)
                {
                    glos = new Glossaire();
                }
                return glos;
            }
        }

        private static void SetParameter(IDbCommand cmd, string name, DbType type, int length, object paramValue)
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

        public void Initilize(Connection con)
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
                InitializeConnexion();

                using (IDbCommand cmd = ImplementeConnexion.Instance.Con.CreateCommand())
                {
                    cmd.CommandText = string.Format("SELECT name FROM sysdatabases WHERE name != 'master' ORDER BY name");
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                            lst.Add(dr["name"].ToString());
                    }
                }
            }
            catch (Exception exc)
            {
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
                InitializeConnexion();

                using (IDbCommand cmd = ImplementeConnexion.Instance.Con.CreateCommand())
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
                string MasterDirectory = ImplementUtilities.Instance.MasterDirectoryConfiguration;
                ImplementLog.Instance.PutLogMessage(MasterDirectory, DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + " : Récupération de toutes les bases de Données SQLServer : " + exc.Message, DirectoryLog, MasterDirectory + "LogFile.txt");
                throw new Exception(exc.Message);
            }
            return bd;
        }

        #endregion

        #region Loadings

        public void InitializeConnexion()
        {
            try
            {
                if (ImplementeConnexion.Instance.Con.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Con.Open();
            }
            catch (Exception)
            {
                
            }
        }   
        
        public List<string> LoadString(string field, string table)
        {
            InitializeConnexion();

            List<string> list = new List<string>();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "SELECT " + field + " FROM " + table + " ORDER BY " + field + " ";

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    list.Add(dr[field].ToString());
                }

                dr.Dispose();
            }

            return list;
        }                                                           

        public int SelectId(string table, string field)
        {
            InitializeConnexion();

            int id = 0;

            using (IDbCommand cmd = ImplementeConnexion.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "SELECT id FROM " + table + " WHERE designation = '" + field + "'";

                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    id = Convert.ToInt32(dr["id"].ToString());
                }

                dr.Dispose();
            }

            return id;
        }

        public DataTable LoadGrid(string table, string orderBy)
        {
            InitializeConnexion();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM " + table + " ORDER BY " + orderBy + " DESC";
                DataTable dt = new DataTable();
                adapter = new SqlDataAdapter((SqlCommand)cmd);               
                adapter.Fill(dt);

                return dt;
            }
        }

        #endregion

        #region Gestion des droits d'accès sur les tables

        public List<int> GetDroitsUser(int idUser)
        {
            List<int> droits = new List<int>();

            try
            {
                InitializeConnexion();

                using (IDbCommand cmd = ImplementeConnexion.Instance.Con.CreateCommand())
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
            }
            catch (Exception exc)
            {
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
                InitializeConnexion();
 
                foreach (int droit in permission)
                {
                    if (droit == 0)
                    {
                        // Les droits pour le super administrateur de la base des données

                        string query = @"EXEC sp_addsrvrolemember '" + loginName + @"','SysAdmin' 
                            EXEC sp_addsrvrolemember '" + loginName + @"','Admin' 
                            EXEC sp_addrolemember 'db_owner','" + username + @"'
                            EXEC sp_addrolemember 'db_accessadmin','" + username + @"'";

                        using (IDbCommand cmd = ImplementeConnexion.Instance.Con.CreateCommand())
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

                        using (IDbCommand cmd1 = ImplementeConnexion.Instance.Con.CreateCommand())
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

                        using (IDbCommand cmd2 = ImplementeConnexion.Instance.Con.CreateCommand())
                        {
                            cmd2.CommandText = string.Format(query);
                            cmd2.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                string MasterDirectory = ImplementUtilities.Instance.MasterDirectoryConfiguration;
                ImplementLog.Instance.PutLogMessage(MasterDirectory, DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + " : Echec d'attribution des droits à l'utilisateur, veuillez réessayez ultérieurement : " + exc.Message, DirectoryLog, MasterDirectory + "LogFile.txt");
                throw new Exception(exc.Message);
            }
        }

        public void RevokePermission(List<int> permission, string loginName, string username)
        {
            try
            {
                InitializeConnexion();

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

                        using (IDbCommand cmd1 = ImplementeConnexion.Instance.Con.CreateCommand())
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

                        using (IDbCommand cmd2 = ImplementeConnexion.Instance.Con.CreateCommand())
                        {
                            cmd2.CommandText = string.Format(query);
                            cmd2.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                string MasterDirectory = ImplementUtilities.Instance.MasterDirectoryConfiguration;
                ImplementLog.Instance.PutLogMessage(MasterDirectory, DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + " : Echec retrait des droits à l'utilisateur, veuillez réessayez ultérieurement : " + exc.Message, DirectoryLog, MasterDirectory + "LogFile.txt");
                throw new Exception(exc.Message);
            }
        }
        #endregion

        #region Common

        public void Delete(int id, string procedure)
        {
            InitializeConnexion();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Con.CreateCommand())
            {
                cmd.CommandText = procedure;
                cmd.CommandType = CommandType.StoredProcedure;


                SetParameter(cmd, "@id", DbType.Int32, 4, id);

                int record = cmd.ExecuteNonQuery();

                if (record == 0)
                    throw new InvalidOperationException("That id does not exist !!!");
            }
        }

        public int Nouveau(string table)
        {
            int id = 0;

            InitializeConnexion();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "SELECT MAX(id) as lastId FROM " + table;

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    if (rd["lastId"] == DBNull.Value)
                        id = 1;
                    else
                        id = Convert.ToInt32(rd["lastId"].ToString()) + 1;
                }

                rd.Dispose();
            }

            return id;
        }

        #endregion

        #region Fournisseur

        public void ControleFournisseur(Fournisseur fss, int action = 1)
        {
            InitializeConnexion();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "sp_merge_fss";
                cmd.CommandType = CommandType.StoredProcedure;

                SetParameter(cmd, "@code", DbType.Int32, 4, fss.Code);
                SetParameter(cmd, "@noms", DbType.String, 100, fss.Noms);
                SetParameter(cmd, "@phone", DbType.String, 30, fss.Phone);
                SetParameter(cmd, "@email", DbType.String, 30, fss.Email);
                SetParameter(cmd, "@adresse", DbType.String, 100, fss.Adresse);
                SetParameter(cmd, "@action", DbType.Int32, 4, action);

                cmd.ExecuteNonQuery();
            }
        }

        #endregion

        #region Categories

        public void ControleCategorieClient(CategorieClient categ, int action = 1)
        {
            InitializeConnexion();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "sp_merge_categorie_client";
                cmd.CommandType = CommandType.StoredProcedure;

                SetParameter(cmd, "@code", DbType.Int32, 4, categ.Code);
                SetParameter(cmd, "@noms", DbType.String, 100, categ.Designation);
                SetParameter(cmd, "@action", DbType.Int32, 4, action);

                cmd.ExecuteNonQuery();
            }
        }

        public void ControleCategoriePiece(CategoriePiece categ, int action = 1)
        {
            InitializeConnexion();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "sp_merge_categorie_piece";
                cmd.CommandType = CommandType.StoredProcedure;

                SetParameter(cmd, "@code", DbType.Int32, 4, Convert.ToInt32(categ.Code));
                SetParameter(cmd, "@designation", DbType.String, 100, categ.Designation);
                SetParameter(cmd, "@action", DbType.Int32, 4, action);

                cmd.ExecuteNonQuery();
            }
        }

        #endregion

        #region Client

        public void ControleClient(Client client, int action)
        {
            InitializeConnexion();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "sp_merge_client";
                cmd.CommandType = CommandType.StoredProcedure;

                SetParameter(cmd, "@code", DbType.Int32, 4, client.CodeCategorieClient);
                SetParameter(cmd, "@code", DbType.Int32, 4, client.Code);
                SetParameter(cmd, "@noms", DbType.String, 100, client.Noms);
                SetParameter(cmd, "@phone", DbType.String, 100, client.Phone);
                SetParameter(cmd, "@email", DbType.String, 100, client.Email);
                SetParameter(cmd, "@adresse", DbType.String, 100, client.Adresse);
                SetParameter(cmd, "@action", DbType.Int32, 4, action);

                cmd.ExecuteNonQuery();
            }
        }

        #endregion

        #region Piece

        public void ControlePiece(Piece piece, int action = 1)
        {
            InitializeConnexion();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "sp_merge_piece";
                cmd.CommandType = CommandType.StoredProcedure;

                SetParameter(cmd, "@code_categ", DbType.Int32, 4, Convert.ToInt32(piece.CodeCategoriePiece));
                SetParameter(cmd, "@code", DbType.Int32, 4, Convert.ToInt32(piece.Code));
                SetParameter(cmd, "@designation", DbType.String, 100, piece.Designation);
                SetParameter(cmd, "@numero", DbType.String, 100, piece.NumeroSerie);
                SetParameter(cmd, "@lieu", DbType.String, 100, piece.LieuFabrication);
                SetParameter(cmd, "@usage", DbType.String, 100, piece.Usage);
                SetParameter(cmd, "@action", DbType.Int32, 4, action);

                cmd.ExecuteNonQuery();
            }
        }

        #endregion

        #region Approvisionnement

        public void ControleApprov(Approvisionnement approv, int action)
        {
            InitializeConnexion();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "sp_merge_approv";
                cmd.CommandType = CommandType.StoredProcedure;

                SetParameter(cmd, "@code_categ", DbType.Int32, 4, approv.CodeFournisseur);
                SetParameter(cmd, "@code", DbType.Int32, 4, approv.Code);
                SetParameter(cmd, "@agent", DbType.String, 100, approv.Agent);
                SetParameter(cmd, "@action", DbType.Int32, 4, action);

                cmd.ExecuteNonQuery();
            }
        }

        public void ControleApprovDetail(DetailApprovisionnement approv, int action)
        {
            InitializeConnexion();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "sp_merge_detail_approv";
                cmd.CommandType = CommandType.StoredProcedure;

                SetParameter(cmd, "@code_approv", DbType.Int32, 4, approv.CodeApprov);
                SetParameter(cmd, "@code", DbType.Int32, 4, approv.Code);
                SetParameter(cmd, "@code_piece", DbType.Int32, 4, approv.CodePiece);
                SetParameter(cmd, "@quantite", DbType.Int32, 4, approv.Quantite);
                SetParameter(cmd, "@prix", DbType.Double, 8, approv.Prix);
                SetParameter(cmd, "@action", DbType.Int32, 4, action);

                cmd.ExecuteNonQuery();
            }
        }

        #endregion

        #region Vente

        public void ControleVente(Vente vente, int action)
        {
            InitializeConnexion();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "sp_merge_vente";
                cmd.CommandType = CommandType.StoredProcedure;

                SetParameter(cmd, "@code_client", DbType.Int32, 4, vente.CodeClient);
                SetParameter(cmd, "@code", DbType.Int32, 4, vente.Code);
                SetParameter(cmd, "@agent", DbType.String, 100, vente.Agent);
                SetParameter(cmd, "@action", DbType.Int32, 4, action);

                cmd.ExecuteNonQuery();
            }
        }

        public void ControleVenteDetail(DetailVente vente, int action)
        {
            InitializeConnexion();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "sp_merge_detail_vente";
                cmd.CommandType = CommandType.StoredProcedure;

                SetParameter(cmd, "@code_vente", DbType.Int32, 4, vente.CodeVente);
                SetParameter(cmd, "@code", DbType.Int32, 4, vente.Code);
                SetParameter(cmd, "@code_piece", DbType.Int32, 4, vente.CodePiece);
                SetParameter(cmd, "@quantite", DbType.Int32, 4, vente.Quantite);
                SetParameter(cmd, "@prix", DbType.Double, 8, vente.Prix);
                SetParameter(cmd, "@action", DbType.Int32, 4, action);

                cmd.ExecuteNonQuery();
            }
        }

        #endregion

        #region Mode de Paiement

        public void ControleModePaiement(ModePaiement mode, int action)
        {
            InitializeConnexion();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "sp_merge_mode_pmt";
                cmd.CommandType = CommandType.StoredProcedure;

                SetParameter(cmd, "@code", DbType.Int32, 4, mode.Code);
                SetParameter(cmd, "@designation", DbType.String, 100, mode.Designation);
                SetParameter(cmd, "@action", DbType.Int32, 4, action);

                cmd.ExecuteNonQuery();
            }
        }

        #endregion

        // TODO: Créer la region COMMANDE
    }
}
