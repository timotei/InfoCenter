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

namespace InfoCenter.Forms
{
    public partial class FrmSplash : Form
    {
        public FrmSplash(System.Drawing.Icon icon, System.Drawing.Image backgroundImage)
        {
            InitializeComponent();
            Icon = icon;
            BackgroundImage = backgroundImage;
            Activate();
        }

        /// <summary>
        /// Seteaza status-ul pe forma
        /// </summary>
        /// <param name="newStatus">noul status</param>
        public void SetStatus(string newStatus)
        {
            statusLabel.Text = newStatus;
        }

    }
}