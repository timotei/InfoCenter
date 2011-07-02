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