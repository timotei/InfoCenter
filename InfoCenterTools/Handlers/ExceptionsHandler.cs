/*
   Copyright (C) 2007 - 2011 by Timotei Dolean <timotei21@gmail.com>
   Part of the Info Center Project

   This program is free software; you can redistribute it and/or modify
   it under the terms of the GNU General Public License as published by
   the Free Software Foundation; either version 2 of the License, or
   (at your option) any later version.
   This program is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY.

   See the LICENSE file for more details.
*/
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
