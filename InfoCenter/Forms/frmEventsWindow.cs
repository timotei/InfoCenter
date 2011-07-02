// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System.Windows.Forms;
using InfoCenter.Util;

namespace InfoCenter.Forms
{
    public partial class FrmEventsWindow : Telerik.WinControls.RadForm
    {
        /// <summary>
        /// Adevarat daca afiseaza evenimentele avasanate
        /// </summary>
        public bool DevEvents { get; set; }

        public FrmEventsWindow()
        {
            InitializeComponent();
            FillEvents();
        }

        public void FillEvents()
        {
            lista.Items.Clear();
            foreach (var de in Handlers.EventsHandler.Instance.Events)
            {
                if (de.Dev && !DevEvents)
                    continue;
                lista.Items.Add(de.Message);
            }
        }

        private void btnAvansat_Click(object sender, System.EventArgs e)
        {
            DevEvents = !DevEvents;
            FillEvents();
        }

        private void radButton1_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Config.AppPath + "log_infocenter.log");
            }
            catch (System.IO.FileNotFoundException)
            {
                Messages.ShowMessageBox(Messages.FILE_NOT_FOUND, "error");
            }
        }
    }
}