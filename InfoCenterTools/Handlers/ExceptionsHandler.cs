// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System;
using System.Collections.Generic;
using InfoCenter.Util;

namespace InfoCenter.Handlers
{
    /// <summary>
    /// Tine evidenta exceptiilor
    /// </summary>
    public sealed class ExceptionsHandler
    {
        #region Singleton
        private static ExceptionsHandler _Instance = new ExceptionsHandler();
        private ExceptionsHandler() { Exceptions = new List<Exception>(); }
        public static ExceptionsHandler Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ExceptionsHandler();
                return _Instance;
            }
        }
        #endregion
        /// <summary>
        /// Lista exceptiilor
        /// </summary>
        public List<Exception> Exceptions { get; set; }

        /// <summary>
        /// Adauga o exceptie
        /// </summary>
        /// <param name="ex">Exceptia</param>
        /// <param name="msg">Mesajul afisat utilizatorului</param>
        public void AddException(Exception ex, string msg)
        {
            Exceptions.Add(ex);
            if (msg != "")
            {
                Messages.ShowMessageBox(msg, " ", "error");
            }

            Logging.Instance.Write(DateTime.Now + " |Exception|" + ex.Message + "\n\t\t" + ex.StackTrace);
            if (ex.InnerException != null)
                Logging.Instance.Write("\r\n\r\n     |Inner Exception|" + ex.InnerException.Message);
        }
    }
}
