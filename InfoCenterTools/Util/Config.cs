﻿/*
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

namespace InfoCenter.Util
{
    /// <summary>
    /// Tine evidenta configuratiilor folosite in aplicatie
    /// </summary>
    public static class Config
    {
        // General paths
        private static readonly string MainDataPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static readonly string AppPath = MainDataPath + @"\InfoCenter\";
        public static readonly string AppDataPath = AppPath + @"data\";

        public static readonly string LectiiListPath = AppDataPath + @"lectii_content.xml";
        public static readonly string FragmenteDeCodPath = AppPath + @"code_snippets.xml";
        public static readonly string ProblemePath = AppDataPath + @"probleme\";

        // updates paths
        public const string WebsiteRoot = @"http://steaua.net/updates/";
        public static readonly string WebsiteUpdatesPath = WebsiteRoot + "ic_updates.xml";

        // Database
        //TODO: encrypt password
        internal static string DbPass = "gigibecali";
        internal static string DbFileName = "ic_database.mdb";
        public static string DbFilePath = AppPath + DbFileName;
        public static string DbConString = string.Format(
            "Provider=Microsoft.JET.OLEDB.4.0;Data Source={0};Jet OLEDB:Database Password={1}",
                                AppPath + DbFileName, DbPass);
    }
}
