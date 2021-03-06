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
//#define debug
using System;
using System.Diagnostics;
using System.Windows.Forms;
using InfoCenter.Classes;
using InfoCenter.Forms;
using InfoCenter.Util;
using System.IO;

namespace InfoCenter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainUnhandledException;
#if debug
            try
            {
#endif
            if (IsStarted())
            {
                Messages.ShowMessageBox("Aplicaţia a fost pornită odată.", "warn");
                return;
            }

            if (!HasNecessaryFiles())
                return;

            if (new FrmLogin().ShowDialog() != DialogResult.Yes) // nu am fost autentificat
            {
                return;
            }

            Form.CheckForIllegalCrossThreadCalls = false;


            Logging.Instance.OpenLog(Config.AppPath + "log_infocenter_continut.log");
            Settings.Instance.LoadSettings(Config.AppPath + "Settings.xml");

            Splasher.Show(Properties.Resources.iconInfoCenter,Properties.Resources.imgLoading);
            Splasher.Status = Messages.LODING_APP;

            Application.Run(new MainForm());
#if debug
            }
            catch (Exception e)
            {
                Messages.ShowMessageBox("Eroare: " + e.Message, "Eroare","error");
                Logging.Instance.write(e.Message + "\r\n" + e.StackTrace);
            }
#endif
        }

        /// <summary>
        /// Verifica daca are fisierele necesare (settings.xml, si ic_database.mdb)
        /// </summary>
        /// <returns></returns>
        private static bool HasNecessaryFiles()
        {
            if (!File.Exists(Config.AppPath + "Settings.xml"))
            {
                Messages.ShowMessageBox("Fişierul cu setări lipseşte. Reinstalaţi aplicaţia.",
                    "Ops... Eroare", "error");
                return false;
            }

            if (!File.Exists(Config.DbFilePath))
            {
                Messages.ShowMessageBox("Baza de date lipseşte. Reinstalaţi aplicaţia.",
                    "Ops... Eroare", "error");
                return false;
            }

            return true;
        }

        static void CurrentDomainUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Messages.ShowMessageBox("Eroare in aplicaţie ","Eroare", "error");
            if (e.ExceptionObject != null)
                Logging.Instance.Write(e.ExceptionObject.ToString());
        }

        /// <summary>
        /// Returneaza o valoarea de adevar daca aplicatia este pornita odata
        /// </summary>
        /// <returns></returns>
        private static bool IsStarted()
        {
            return (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length >= 2);
        }
    }
}