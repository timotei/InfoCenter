// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
//#define debug
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using InfoCenter.Classes;
using InfoCenter.Util;

namespace InfoCenter
{
    public static class Program
    {
        [STAThread]
        public static void Main()
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


            Control.CheckForIllegalCrossThreadCalls = false;

            Logging.Instance.OpenLog(Config.AppPath + "log_infocenter.log");
            Settings.Instance.LoadSettings(Config.AppPath + "Settings.xml");

            Splasher.Show(Properties.Resources.iconInfoCenter, Properties.Resources.imgLoading);
            Splasher.Status = Messages.LODING_APP;

            Application.Run(new MainForm());
#if debug
            }
            catch (Exception e)
            {
                Logging.Instance.write("Eroare în aplicaţie:\r\n" + e.Message + "\r\nStackTrace: " + e.StackTrace);
                Messages.ShowMessageBox("Eroare în aplicaţie. Aplicaţia se va închide.",
                    "Ops... Eroare","error");
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
            Messages.ShowMessageBox("Eroare in aplicaţie ", "Eroare", "error");
            if (e.ExceptionObject != null)
                Logging.Instance.Write(e.ExceptionObject.ToString());
        }

        /// <summary>
        /// Returneaza o valoarea de adevar daca aplicatia este pornita
        /// </summary>
        /// <returns></returns>
        private static bool IsStarted()
        {
            return (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length >= 2);
        }
    }
}