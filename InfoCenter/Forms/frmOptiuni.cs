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
using System.IO;
using System.Windows.Forms;
using InfoCenter.Util;

namespace InfoCenter.Forms
{
    public partial class FrmOptiuni : Telerik.WinControls.RadForm
    {
        public FrmOptiuni()
        {
            InitializeComponent();

            txtLocatieCPP.Text = Settings.Instance.GetSetting(Settings.CPPPath).Valoare;
            txtQuickSavePath.Text = Settings.Instance.GetSetting(Settings.QuickSavePath).Valoare;

            txtPatternCPP.Text = Settings.Instance.GetSetting(Settings.CPPPattern).Valoare;

        }
        private void btnCautaBC_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtLocatieCPP.Text = Path.GetFullPath(openFileDialog.FileName);
            }
        }

        private void btnCautaQuickSave_Click(object sender, System.EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtQuickSavePath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnSaveSettings_Click(object sender, System.EventArgs e)
        {
            bool errorEncountered = false;
            Settings.Instance.SetSetting(Settings.CPPPattern, txtPatternCPP.Text);

            // CPP path
            if (!File.Exists(txtLocatieCPP.Text))
            {
                errorProvider.SetError(txtLocatieCPP, Messages.COMPILER_EXE_NOT_FOUND);
                errorEncountered = true;
            }
            else
            {
                errorProvider.SetError(txtLocatieCPP, "");
                Settings.Instance.SetSetting(Settings.CPPPath, txtLocatieCPP.Text);
            }

            // QuickSave path
            if (!Directory.Exists(txtQuickSavePath.Text))
            {
                errorProvider.SetError(txtQuickSavePath, Messages.QUICK_SAVE_FOLDER_NOT_FOUND);
                errorEncountered = true;
            }
            else
            {
                errorProvider.SetError(txtQuickSavePath, "");
                Settings.Instance.SetSetting(Settings.QuickSavePath, txtQuickSavePath.Text);
            }

            Settings.Instance.SaveSettings();

            if (errorEncountered)
                Messages.ShowMessageBox(Messages.SETTINGS_NOT_SAVED, "info");
            else
                Messages.ShowMessageBox(Messages.SETTINGS_SAVED, "info");

        }
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void lblDetalii_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Messages.ShowMessageBox(Messages.COMPILER_ARGS_DETAILS, "info");
        }

    }
}