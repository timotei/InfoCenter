// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System;
using System.IO;

namespace InfoCenter.Util
{
    /// <summary>
    /// Log-eaza evenimentele din aplicatie
    /// </summary>
    public sealed class Logging
    {
        #region Singleton
        private static Logging _Instance = new Logging();
        private Logging() { }
        public static Logging Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new Logging();
                return _Instance;
            }
        }
        #endregion
        /// <summary>
        /// Fluxul folosit pentru scrierea in fisier
        /// </summary>
        private StreamWriter _sw;

        /// <summary>
        /// Deschide un log in fisierul specificat
        /// </summary>
        /// <param name="path">Locatia fisierului.</param>
        public void OpenLog(string path)
        {
            try
            {
                _sw = new StreamWriter(path, true) {AutoFlush = true};

                Write("\n===================");
                Write("Logarea inceputa: " + DateTime.Now);
            }
            catch (Exception e)
            {
                Handlers.ExceptionsHandler.Instance.AddException(e,"");
            }
        }

        /// <summary>
        /// Inchide log-ul
        /// </summary>
        public void CloseLog()
        {
            Write("Logarea terminata " + DateTime.Now);
            if (_sw != null) 
                _sw.Close();
        }

        /// <summary>
        /// Adauga text in log
        /// </summary>
        /// <param name="text">Textul care trebuie scris</param>
        public void Write(string text)
        {
            if (_sw == null || !_sw.BaseStream.CanWrite) 
                return;

            _sw.WriteLine(text);
        }
    }
}
