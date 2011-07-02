// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System.Xml.Serialization;
using System.Collections.Generic;
using System;

namespace InfoCenter.Classes
{
    /// <summary>
    /// Reprezinta un container cu setari
    /// </summary>
    [XmlRoot("settings")]
    [Serializable]
    public class SettingsHolder
    {
        public SettingsHolder()
        {
            Settings = new List<Setting>();
        }
        /// <summary>
        /// Lista setarilor
        /// </summary>
        [XmlElement("setting")]
        public List<Setting> Settings { get; set; }
    }

    /// <summary>
    /// Reprezinta o setare care are un nume si valoarea aferenta
    /// </summary>
    [Serializable]
    public class Setting
    {
        /// <summary>
        /// Numele setarii
        /// </summary>
        [XmlAttribute("name")]
        public string Nume { get; set; }
        /// <summary>
        /// Valoarea setarii
        /// </summary>
        [XmlAttribute("value")]
        public string Valoare { get; set; }

        public Setting()
        { }

        /// <summary>
        /// Initializeaza o setare noua
        /// </summary>
        /// <param name="name">Numele setarii</param>
        /// <param name="value">Valoare setarii</param>
        public Setting(string name, string value)
        {
            Nume = name;
            Valoare = value;
        }

        public override string ToString()
        {
            return Valoare;
        }

        /// <summary>
        /// Converteste valoarea curenta in tipul int.
        /// </summary>
        /// <returns></returns>
        public int ToInt()
        {
            int result;
            int.TryParse(Valoare, out result);
            return result;
        }
    }
}