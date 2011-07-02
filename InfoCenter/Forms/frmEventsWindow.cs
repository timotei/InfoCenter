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