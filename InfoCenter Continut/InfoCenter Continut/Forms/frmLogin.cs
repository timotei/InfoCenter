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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIntra_Click(object sender, System.EventArgs e)
        {
            lblStatus.Visible = true;

            string username = txtCont.Text;
            string password = txtParola.Text;

            if (username.Length == 0 || password.Length == 0)
            {
                lblStatus.Text = "Introduceţi informaţiile complete.";
                return;
            }

            if (username.Equals("admin") && password.Equals("pass"))
            {
                lblStatus.Text = "Informaţii de autentificare corecte.";
            }
            else
            {
                lblStatus.Text = "Informaţii de autentificare incorecte. Mai incercaţi odată.";
                return;
            }

            DialogResult = DialogResult.Yes;
            Close();
        }
    }
}