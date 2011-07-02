// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System;
using System.Data.OleDb;
using InfoCenter.Util;

namespace InfoCenter.Handlers
{
    /// <summary>
    /// Realizeaza conexiunea cu baza de date si executa query-uri
    /// </summary>
    public sealed class DatabaseHandler
    {
        #region Singleton
        private  static DatabaseHandler _Instance = new DatabaseHandler();
        private DatabaseHandler() { }
        public  static DatabaseHandler Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DatabaseHandler();
                return _Instance;
            }
        }
        #endregion
        private  OleDbConnection _con;

        #region FileSetup
        /// <summary>
        /// Initializeaza o conexiunea cu baza de date pe baza unui connection string
        /// </summary>
        /// <param name="dbConString">Connection string</param>
        /// <returns></returns>
        public  bool InitializeDBAcess(string dbConString)
        {
            try
            {
                _con = new OleDbConnection(dbConString);
                _con.Open();
            }
            catch (Exception e)
            {
                ExceptionsHandler.Instance.AddException(e, Messages.ERROR_CONNECT_DB);
                return false;
            }
            return true;
        }
        /// <summary>
        /// Inchide conexiunea
        /// </summary>
        public  void CloseDBAcess()
        {
            try
            {
                _con.Close();
            }
            catch (Exception e)
            {
                ExceptionsHandler.Instance.AddException(e, "");
            }
        }
        #endregion

        #region General SQL methods
        /// <summary>
        /// Executa un query pe conexiunea deschisa
        /// </summary>
        /// <param name="query">Query-ul SQL care trebuie executat</param>
        /// <param name="parameters">Sirul de parametrii</param>
        /// <returns>OleDbDataReader result</returns>
        public  OleDbDataReader DoQuery(string query, params OleDbParameter[] parameters)
        {
            try
            {
                if (_con != null && _con.State != System.Data.ConnectionState.Open)
                    _con.Open();

                using (OleDbCommand com = new OleDbCommand(query, _con))
                {
                    if (parameters != null && parameters.Length > 0)
                        com.Parameters.AddRange(parameters);
                    return com.ExecuteReader();
                }
            }
            catch (Exception e)
            {
                ExceptionsHandler.Instance.AddException(e, "");
                return null;
            }
        }
        /// <summary>
        /// Executa un query pe conexiunea deschisa
        /// </summary>
        /// <param name="query">Query-ul SQL care trebuie executat</param>
        /// <param name="parameters">Sirul de parametrii</param>
        public  void DoQueryNonQuery(string query, params OleDbParameter[] parameters)
        {
            try
            {
                if (_con != null && _con.State != System.Data.ConnectionState.Open)
                    _con.Open();

                using (OleDbCommand com = new OleDbCommand(query, _con))
                {
                    if (parameters != null && parameters.Length > 0)
                        com.Parameters.AddRange(parameters);
                    com.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                ExceptionsHandler.Instance.AddException(e, "");
                return;
            }
        }
        /// <summary>
        /// Executa o procedura stocata pe conexiunea deschisa
        /// </summary>
        /// <param name="sp_name">Numele procedurii</param>
        /// <param name="parameters">Sirul de parametrii</param>
        /// <returns>OleDbDataReader result</returns>
        public  OleDbDataReader DoStoredProcReader(string sp_name, params OleDbParameter[] parameters)
        {
            try
            {
                if (_con != null && _con.State != System.Data.ConnectionState.Open)
                    _con.Open();

                using (OleDbCommand com = new OleDbCommand(sp_name, _con))
                {
                    if (parameters != null && parameters.Length > 0)
                        com.Parameters.AddRange(parameters);
                    com.CommandType = System.Data.CommandType.StoredProcedure;
                    return com.ExecuteReader();
                }
            }
            catch (Exception e)
            {
                ExceptionsHandler.Instance.AddException(e, Messages.ERROR_DATABASE);
                return null;
            }
        }
        /// <summary>
        /// Executa o procedura stocata pe conexiunea deschisa
        /// </summary>
        /// <param name="sp_name">Numele procedurii</param>
        /// <param name="parameters">Sirul de parametrii</param>
        /// <returns></returns>
        public  void DoStoredProcNonQuery(string sp_name, params OleDbParameter[] parameters)
        {
            try
            {
                if (_con != null && _con.State != System.Data.ConnectionState.Open)
                    _con.Open();

                using (OleDbCommand com = new OleDbCommand(sp_name, _con))
                {
                    if (parameters != null && parameters.Length > 0)
                        com.Parameters.AddRange(parameters);
                    com.CommandType = System.Data.CommandType.StoredProcedure;
                    com.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                ExceptionsHandler.Instance.AddException(e, Messages.ERROR_DATABASE);
                return;
            }
        }
        #endregion
    }
}