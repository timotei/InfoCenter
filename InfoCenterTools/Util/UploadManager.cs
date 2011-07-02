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
using System.IO;
using System.Net;

namespace InfoCenter.Util
{
    /// <summary>
    /// Administreaza upload-ul pentru versiunile de continut
    /// </summary>
    public static class UploadManager
    {
        /// <summary>
        /// Conexiunea la serverul FTP
        /// </summary>
        public static FtpWebRequest Request
        {
            get;
            set;
        }

        private static string _url;
        private static string _username;
        private static string _password;

        /// <summary>
        /// Uploadeaza toate fisierele (db,files)
        /// </summary>
        /// <returns></returns>
        public static bool UploadAll()
        {
            return (UploadFile("") && UploadFile(""));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool DoLogin(string url,string username, string password)
        {
            Request = (FtpWebRequest)FtpWebRequest.Create(url);
            Request.Method = WebRequestMethods.Ftp.UploadFile;
            Request.Credentials = new NetworkCredential(username, password);
            Request.UsePassive = true;
            Request.UseBinary = true;
            Request.KeepAlive = false;
            return true;
        }
        /// <summary>
        /// Uploadeaza fisiereul din path-ul specificat
        /// </summary>
        /// <param name="filePath">Locatia fisierului</param>
        /// <returns></returns>
        private static bool UploadFile(string filePath)
        {
            if (Request == null)
                return false;
            try
            {
                //DoLogin(_url, _username, _password);
                //Request.Pa

                FileStream stream = File.OpenRead(filePath); //TODO 
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();

                Stream reqStream = Request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Close();
                return true;
            }
            catch (Exception e)
            {
                return true;
            }
        }

    }
}
