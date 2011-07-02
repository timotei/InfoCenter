// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System.Xml.Serialization;
using System;
using System.IO;
using InfoCenter.Classes;
using InfoCenter.Extensions;
using InfoCenter.Handlers;

namespace InfoCenter.Util
{
    /// <summary>
    /// Tine evidenta setarilor folosite in aplicatie
    /// </summary>
    public sealed class Settings
    {
        #region Singleton
        private static Settings _Instance = new Settings();
        private Settings()
        {
            Setari = new SettingsHolder();
        }
        public static Settings Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new Settings();
                return _Instance;
            }
        }
        #endregion
        #region Setarile existente
        /// <summary>
        /// Locatia compilatorului C++
        /// </summary>
        public static string CPPPath
        {
            get { return "CPPPath";  }
        }
        /// <summary>
        /// Locatia pentru salvari rapide
        /// </summary>
        public static string QuickSavePath
        {
            get { return "QuickSavePath";  }
        }
        /// <summary>
        /// Sablonul pentru argumentele compilatorului de C++
        /// </summary>
        public static string CPPPattern
        {
            get { return "CPPPattern"; }
        }
        /// <summary>
        /// Numarul versiunii curente ale fisierelor cu lectii si baza de date.
        /// </summary>
        public static string CurrentVersion
        {
            get { return "CurrentVersion"; }
        }
        #endregion        
        private string _path = string.Empty;

        /// <summary>
        /// Calea catre fisierul cu setari
        /// </summary>
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }
        
        /// <summary>
        /// SettingsHolder-ul cu setari
        /// </summary>
        public SettingsHolder Setari
        {
            get;
            set;
        }

        /// <summary>
        /// Incarca fisierul cu setari si returneaza o valoare in functie de succes
        /// </summary>
        /// <returns></returns>
        public bool LoadSettings(string path)
        {
            try
            {
                _path = path;
                using (StreamReader sr = new StreamReader(path,false))
                {
                    XmlSerializer xmls = new XmlSerializer(typeof(SettingsHolder));
                    Setari = (SettingsHolder)xmls.Deserialize(sr);
                }
            }
            catch (Exception e)
            {
                ExceptionsHandler.Instance.AddException(e, Messages.ERROR_LOAD_SETTINGS);
                return false;
            }
            return true;
        }
        /// <summary>
        /// Salveaza setarile
        /// </summary>
        /// <returns></returns>
        public bool SaveSettings()
        {
            try
            {
                XmlSerializer xmls = new XmlSerializer(typeof(SettingsHolder));
                using (StreamWriter sw = new StreamWriter(_path, false))
                {
                    xmls.Serialize(sw, Setari);
                }
            }
            catch (Exception e)
            {
                Messages.ShowMessageBox("Eroare la salvarea setărilor: " + e.Message,"error");
                Logging.Instance.Write("Eroare la salvarea setărilor: " + e.Message + "\n" + e.StackTrace);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Returneaza adevarat daca exista o valoare setata pentru numele specificat
        /// </summary>
        /// <param name="settingName">Numele setarii</param>
        /// <returns></returns>
        public bool HasSetting(string settingName)
        {
            return Setari.Settings.ContainsSetting(settingName);
        }

        /// <summary>
        /// Returneaza setarea cu numele specificat
        /// </summary>
        /// <param name="settingName">Numele setarii</param>
        /// <returns></returns>
        public Setting GetSetting(string settingName)
        {
            int index = Setari.Settings.IndexOfSetting(settingName);
            if (index == -1)
                return new Setting(settingName, "");
            return Setari.Settings[index];
        }

        /// <summary>
        /// Seteaza o valoare noua setarii cu numele specificat
        /// </summary>
        /// <param name="settingName">Numele setarii</param>
        /// <param name="newValue">Noua valoare</param>
        public void SetSetting(string settingName, string newValue)
        {
            int index = Setari.Settings.IndexOfSetting(settingName);
            if (index == -1)
                Setari.Settings.Add(new Setting(settingName, newValue));
            else
                Setari.Settings[index].Valoare = newValue;
        }
    }

}