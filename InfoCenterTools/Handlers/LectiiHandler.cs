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
using System.Xml.Serialization;
using InfoCenter.Classes;
using InfoCenter.Util;

namespace InfoCenter.Handlers
{
    /// <summary>
    /// Tine evidenta lectiilor, salvare si incarcare din fisier
    /// </summary>
    internal sealed class LectiiHandler
    {
        #region Singleton
        private static LectiiHandler _Instance = new LectiiHandler();
        private LectiiHandler()
        {
            LectiiHolder = new LectiiHolder();
        }
        public static LectiiHandler Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new LectiiHandler();
                return _Instance;
            }
        }
        #endregion
        /// <summary>
        /// Locatia fisierului cu lectii
        /// </summary>
        private string _filePath;

        /// <summary>
        /// Lista lectiilor
        /// </summary>
        public LectiiHolder LectiiHolder { get; set; }

        /// <summary>
        /// Citeste si incarca lectiile
        /// </summary>
        /// <param name="filePath">Locatia fisierului cu Lectii</param>
        /// <returns></returns>
        public  bool ParseFile(string filePath)
        {
            _filePath = filePath;
            LectiiHolder = new LectiiHolder();

            try
            {
                var xmls = new XmlSerializer(typeof(LectiiHolder));
                var streamReader = new System.IO.StreamReader(filePath,false);
                LectiiHolder = (LectiiHolder)xmls.Deserialize(streamReader);

                return true;
            }
            catch (Exception e)
            {
                ExceptionsHandler.Instance.AddException(e,Messages.ERROR_LOAD_LECTII);
                return false;
            }
        }
        /// <summary>
        /// Salveaza fisierul cu lectii
        /// </summary>
        /// <returns></returns>
        public  bool SaveFile()
        {
            try
            {
                var xmls = new XmlSerializer(typeof(LectiiHolder));
                var streamWriter = new System.IO.StreamWriter(_filePath, false);
                xmls.Serialize(streamWriter, LectiiHolder);
                streamWriter.Close();
                return true;
            }
            catch (Exception e)
            {
                ExceptionsHandler.Instance.AddException(e, Messages.ERROR_SAVE_FILE);
                return false;
            }
        }
    }
}
