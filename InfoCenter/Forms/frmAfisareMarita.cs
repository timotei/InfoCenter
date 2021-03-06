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
using System;
using System.Drawing;
using System.Windows.Forms;

namespace InfoCenter.Forms
{
    public partial class FrmAfisareMarita : Telerik.WinControls.RadForm
    {
        /// <summary>
        /// Afiseaza o noua forma cu textul si titlul specificate
        /// </summary>
        /// <param name="title">Titlul formei</param>
        /// <param name="highlighting">Tipul de highlighting folosit</param>
        public FrmAfisareMarita(string title, string highlighting)
        {
            InitializeComponent();
            Text = "Afişare - " + title;
            textBox.SourceTextBox.Font = new Font("Courier New", 16);
            textBox.SourceTextBox.SetHighlighting(highlighting);
            textBox.SourceTextBox.ActiveTextAreaControl.TextArea.Document.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Seteaza textul in textbox
        /// </summary>
        /// <param name="text">Textul afisat</param>
        public void SetText(string text)
        {
            textBox.Text = text;
        }

        private void schimbaFontToolStripMenuIte_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                textBox.Font = fontDialog1.Font;
        }
    }
}