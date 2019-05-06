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
                    cmd.CommandText = string.Format("SELECT name FROM sysdatabases WHERE name!='master' ORDER BY name");
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
    }
}
