using System;
using System.IO;
using System.Net;
using System.Xml;
using InfoCenter.Extensions;
using InfoCenter.Handlers;
using ICSharpCode.SharpZipLib.Zip;

namespace InfoCenter.Util
{
    /// <summary>
    /// Tine evidenta Update-urilor aplicatiei
    /// </summary>
    public static class UpdatesManager
    {
        #region Tipuri de update
        /// <summary>
        /// Update-urile pentru baza de date
        /// </summary>
        public static string DB
        {
            get { return "db"; }
        }
        /// <summary>
        /// Update-urile pentru fisiere
        /// </summary>
        public static string Files
        {
            get { return "files"; }
        }
        #endregion
        /// <summary>
        /// Documentul XML de pe server
        /// </summary>
        public static XmlDocument Document
        {
            get;
            set;
        }
        /// <summary>
        /// Verifica daca exista update-uri si returneaza status-ul
        /// </summary>
        /// <returns></returns>
        public static bool CheckForUpdates()
        {
            if (!UpdateXmlDocument())
                return false;

            return  (NeedsUpdate("db") || NeedsUpdate("files"));
        }

        /// <summary>
        /// Returneaza adevarat daca tipul specificat are nevoie de update
        /// </summary>
        /// <param name="type">Tipul de update: db, files</param>
        /// <returns></returns>
        public static bool NeedsUpdate(string type)
        {
            return (Settings.Instance.GetSetting(type).ToInt() < GetCurrentWebVersion(type));
        }

        /// <summary>
        /// Updateaza tipul specificat
        /// </summary>
        /// <param name="type">Tipul de update: db, files</param>
        /// <returns></returns>
        public static bool DoUpdate(string type)
        {
            Settings.Instance.SetSetting(type, GetCurrentWebVersion(type).ToString());
            return (UpdateFiles(type));
        }
        /// <summary>
        /// Updateaza continutul (db+files)
        /// </summary>
        /// <returns></returns>
        public static bool DoUpdate()
        {
            if (NeedsUpdate("db") && !DoUpdate("db"))
                    return false;
            if (NeedsUpdate("files") && !DoUpdate("files"))
                    return false;
            return true;
        }

        /// <summary>
        /// Actualizeaza fisiere de tipul specficat
        /// </summary>
        /// <param name="type">Tipul de update: db, files</param>
        /// <returns></returns>
        private static bool UpdateFiles(string type)
        {
            DoBackup(type);
            WebClient client = new WebClient();
            string destinationFile = Config.AppPath + Path.GetFileName(GetUpdateLocation(type));
            client.DownloadFile(Config.WebsiteRoot + GetUpdateLocation(type), destinationFile);
            if (type.Equals("files"))
                return UnzipData(destinationFile, Config.AppPath);
            return true;
        }

        private static bool UnzipData(string filePath, string destPath)
        {
            try
            {
                var zip = new FastZip();
                zip.ExtractZip(filePath, destPath, "");
                return true;
            }
            catch (Exception e)
            {
                ExceptionsHandler.Instance.AddException(e, Messages.INVALID_ARCHIVE);
                return false;
            }
        }

        /// <summary>
        /// Creaza copie de siguranta pentru tipul specificat
        /// </summary>
        /// <param name="type">Tipul de update: db, files</param>
        /// <returns></returns>
        private static bool DoBackup(string type)
        {
            string currentFile = Config.AppPath + Path.GetFileName(GetUpdateLocation(type));
            string destinationFile = Config.AppPath + Path.GetFileNameWithoutExtension(GetUpdateLocation(type)) + ".bak";
            try
            {
                if (File.Exists(destinationFile))
                    File.Delete(destinationFile);
                File.Move(currentFile, destinationFile);
                return true;
            }
            catch(Exception e)
            {
                ExceptionsHandler.Instance.AddException(e, Messages.ERROR_CREATE_BACKUP);
                return false;
            }
        }

        /// <summary>
        /// Restaureaza copie de siguranta pentru tipul specificat
        /// </summary>
        /// <param name="type">Tipul de update: db, files</param>
        /// <returns></returns>
        private static bool RestoreBackup(string type)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returneaza locatia update-ului pentru tipul specificat
        /// </summary>
        /// <param name="type">Tipul de update: db, files</param>
        /// <returns></returns>
        private static string GetUpdateLocation(string type)
        {
            try
            {
                return GetAttributeValue("update", "location", type);
            }
            catch (WebException ex)
            {
                ExceptionsHandler.Instance.AddException(ex, Messages.ERROR_GETTING_UPDATES);
                return "";
            }
        }

        /// <summary>
        /// Returneaza valoarea atributului specificat pentru tipul specificat din
        /// cadrul nodului cu numele specificat
        /// </summary>
        /// <param name="nodeName">Numele nodului</param>
        /// <param name="attributeName">Numele atributului</param>
        /// <param name="type">Tipul atributului</param>
        /// <returns></returns>
        private static string GetAttributeValue(string nodeName, string attributeName, string type)
        {
            if (Document == null && !UpdateXmlDocument())
                return "";

            // ChildNodes: 0 - xml version; 1 - updates
            foreach (XmlNode update in Document.ChildNodes[1].ChildNodes)
            {
                if (!update.Name.Equals(nodeName))
                    continue;

                if (update.Attributes["type"] != null && update.Attributes["type"].Value.Equals(type))
                {
                    return update.Attributes[attributeName].Value;
                }
            }
            return "";
        }

        /// <summary>
        /// Returneaza versiunea curenta de pe webserver
        /// </summary>
        /// <param name="type">Tipul update-ului</param>
        /// <returns></returns>
        private static int GetCurrentWebVersion(string type)
        {
            return GetAttributeValue("update", "version", type).ToInt();
        }

        /// <summary>
        /// Actualizeaza Documentul XML curent
        /// </summary>
        /// <returns></returns>
        private static bool UpdateXmlDocument()
        {
            Document = new XmlDocument();
            try
            {
                WebClient client = new WebClient();
                Stream stream = client.OpenRead(Config.WebsiteUpdatesPath);
                Document.Load(stream);
            }
            catch (WebException we)
            {
                ExceptionsHandler.Instance.AddException(we, Messages.ERROR_GETTING_UPDATES);
                return false;
            }
            catch (Exception e)
            {
                ExceptionsHandler.Instance.AddException(e, Messages.ERROR_GETTING_UPDATES);
                return false;
            }
            return true;
        }
    }
}
