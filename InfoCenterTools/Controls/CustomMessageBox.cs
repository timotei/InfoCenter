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
using Telerik.WinControls;
using System.Windows.Forms;

namespace InfoCenter.Controls
{
    public sealed partial class CustomMessageBox : RadForm
    {
        /// <summary>
        /// Initializeaza un nou msg box cu informatiile specificate
        /// </summary>
        /// <param name="title">Titlul mesajului</param>
        /// <param name="message">Mesajul</param>
        public CustomMessageBox(string title,string message)
        {
            InitializeComponent();
            MaximumSize = new System.Drawing.Size((int)(SystemInformation.WorkingArea.Width*0.60),
                (int)(SystemInformation.WorkingArea.Height*0.90));
            lblText.MaximumSize = MaximumSize;
            Text = "        " + title;
            lblText.Text = message;
        }

        private void btnNu_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void btnDa_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }
    }
}
