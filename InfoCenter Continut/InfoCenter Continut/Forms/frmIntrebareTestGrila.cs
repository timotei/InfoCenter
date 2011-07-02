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
using InfoCenter.Classes;
using InfoCenter.Handlers;
using InfoCenter.Util;

namespace InfoCenter.Forms
{
    /// <summary>
    /// Afiseaza o forma pentru editare sau modificarea intrebarii grila
    /// </summary>
    public partial class FrmIntrebareGrila : FrmIntrebare
    {
        /// <summary>
        /// Intrebarea grila asociata formei
        /// </summary>
        public IntrebareGrila IntrebareGrila
        {
            get { return (Intrebare as IntrebareGrila); }
            set { Intrebare = value; }
        }
        /// <summary>
        /// Intrebarea asociata formei
        /// </summary>
        public override IntrebareTest Intrebare { get; set; }
        /// <summary>
        /// Id-ul testului caruia ii este asociata intrebarea
        /// </summary>
        public override int IdTest { get; set; }

        public FrmIntrebareGrila(IntrebareGrila intrebare, int idtest)
        {
            InitializeComponent();
            Intrebare = intrebare;
            IdTest = idtest;
            comboRaspunsCorect.Text = "1";
        }

        /// <summary>
        /// Seteaza informatiile intrebarii pe forma
        /// </summary>
        public override void SetIntrebareInformation()
        {
            if (Intrebare == null)
                return;

            txtIntrebare.Text = IntrebareGrila.Intrebare;
            txtRaspuns1.Text = IntrebareGrila.Raspuns1;
            txtRaspuns2.Text = IntrebareGrila.Raspuns2;
            txtRaspuns3.Text = IntrebareGrila.Raspuns3;
            txtRaspuns4.Text = IntrebareGrila.Raspuns4;
            txtPuncte.Text = IntrebareGrila.Puncte.ToString();
            comboRaspunsCorect.Text = IntrebareGrila.RaspunsCorect.ToString();
        }

        /// <summary>
        /// Returneaza Intrebarea de pe forma, formata din datele 
        /// introduse de utilizator
        /// </summary>
        /// <returns></returns>
        private IntrebareGrila GetIntrebareGrila()
        {
            int id, raspunsCorect;
            if (Intrebare == null)
                id = ResourcesHandler.Instance.GetNextAvailableIntrebareGrilaId();
            else
                id = Intrebare.Id;
            int.TryParse(comboRaspunsCorect.Text, out raspunsCorect);
            float puncte;
            float.TryParse(txtPuncte.Text, out puncte);
            if (txtIntrebare.Text.Length == 0 || txtRaspuns1.Text.Length == 0 || txtRaspuns2.Text.Length == 0 ||
                txtRaspuns3.Text.Length == 0 || txtRaspuns4.Text.Length == 0 || raspunsCorect == 0)
            {
                Messages.ShowMessageBox(Messages.VALUES_UNSPECIFIED, "error");
                return null;
            }

            IntrebareGrila intrebare = new IntrebareGrila(id, IdTest, txtIntrebare.Text, raspunsCorect,
                txtRaspuns1.Text, txtRaspuns2.Text, txtRaspuns3.Text, txtRaspuns4.Text, puncte);
            return intrebare;
        }

        /// <summary>
        /// Returneaza textBox-ul care are focus de pe forma
        /// </summary>
        /// <returns></returns>
        private RichTextBox GetCurrentTextBox()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (!control.GetType().Equals(typeof(RichTextBox)))
                    continue;

                if (control.Focused)
                    return control as RichTextBox;
            }
            return null;
        }

        #region Form
        private void btnSalveazaInchide_Click(object sender, EventArgs e)
        {
            Intrebare = GetIntrebareGrila();
            if (Intrebare == null)
                return;
            ResourcesHandler.Instance.IdsIntrebari.Add(Intrebare.Id);
            DialogResult = DialogResult.OK;
            Close();
        }
        private void btnInchide_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IntrebareTestGrila_Load(object sender, EventArgs e)
        {
            SetIntrebareInformation();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (GetCurrentTextBox() == null)
                return;

            GetCurrentTextBox().Cut();
        }
        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            if (GetCurrentTextBox() == null)
                return;

            GetCurrentTextBox().Copy();
        }
        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            if (GetCurrentTextBox() == null)
                return;

            GetCurrentTextBox().Paste();
        }

        private void boldToolStripButton_Click(object sender, EventArgs e)
        {
            if (GetCurrentTextBox() == null)
                return;

            SetTextFont(GetCurrentTextBox(), boldToolStripButton.Checked, italicToolStripButton.Checked,
                GetCurrentTextBox().Font);
        }
        private void italicToolStripButton_Click(object sender, EventArgs e)
        {
            if (GetCurrentTextBox() == null)
                return;

            SetTextFont(GetCurrentTextBox(), boldToolStripButton.Checked, italicToolStripButton.Checked,
                GetCurrentTextBox().Font);
        }
        private void SetTextFont(RichTextBox textBox, bool bold, bool italic, Font font)
        {
            textBox.SelectionFont = FontUtil.GetFont(font, font.Size, bold, italic);
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            if (!(sender is RichTextBox))
                return;
            int locationY = ((RichTextBox)sender).Location.Y;
            toolStripFont.Location = new Point(toolStripFont.Location.X, locationY + 13);
            boldToolStripButton.Checked = false;
            italicToolStripButton.Checked = false;
        }
        #endregion
    }
}