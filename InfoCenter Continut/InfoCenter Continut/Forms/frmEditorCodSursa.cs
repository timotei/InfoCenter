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
using System.Windows.Forms;
using Telerik.WinControls;

namespace InfoCenter.Forms
{
    /// <summary>
    /// Editor de cod sursa
    /// </summary>
    public partial class FrmEditorCodSursa : RadForm
    {
        public FrmEditorCodSursa(string sourceCode, string highlighting)
        {
            InitializeComponent();
            textBox.SetHighlighting(highlighting);
            textBox.Text = sourceCode;
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        /// Returneaza Codul sursa scris
        /// </summary>
        /// <returns></returns>
        public string GetCurrentSourceCode()
        {
            return textBox.Text;
        }
    }
}