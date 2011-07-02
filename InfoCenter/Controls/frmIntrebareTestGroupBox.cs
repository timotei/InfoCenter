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
using InfoCenter.Classes;

namespace InfoCenter.Controls
{
    public partial class FrmIntrebareTestGroupBox : TestGroupBox
    {
        /// <summary>
        /// Numarul curent al intrebarii
        /// </summary>
        public override int NrCrt { get; set; }

        /// <summary>
        /// Intrebarea asociata groupBox-ului
        /// </summary>
        public override IntrebareTest Intrebare { get; set; }

        public FrmIntrebareTestGroupBox()
        {
            InitializeComponent();
            Intrebare = null;
        }

        public FrmIntrebareTestGroupBox(IntrebareTest intrebare)
        {
            InitializeComponent();
            Intrebare = intrebare;
            if (intrebare == null)
                return;

            lblIntrebare.Text = Intrebare.Intrebare;
            groupBox.Text = "Întrebarea nr. ";
        }

        /// <summary>
        /// Seteaza numarul intrebarii
        /// </summary>
        /// <param name="nr">Numarul de setat</param>
        public override void SetIntrebareNr(int nr)
        {
            NrCrt = nr;
            groupBox.Text = "Întrebarea nr. " + nr;
        }

        /// <summary>
        /// Valideaza raspunsurile, marcheaza cele corecte/incorecte si returneaza rezultatul
        /// </summary>
        /// <returns></returns>
        public override bool ValidateRaspuns(bool markOnForm)
        {
            if (Intrebare == null)
                return false;

            bool raspunsCorect = true;

            string[] outputArray = txtRaspuns.Text.Replace("\r\n", " ").Trim().Split(' ');
            string[] correctArray = Intrebare.RaspunsCorect.Replace("\r\n", " ").Trim().Split(' ');

            if (outputArray.Length != correctArray.Length)
                raspunsCorect = false;
            else
                for (int i = 0; i < outputArray.Length; i++)
                    if (!outputArray[i].Trim().Equals(correctArray[i].Trim()))
                        raspunsCorect = false;

            if (!markOnForm)
                return raspunsCorect;

            lblIntrebare.Text = "      " + lblIntrebare.Text;
            lblIntrebare.Image = (raspunsCorect ? Properties.Resources.imgOk16 : Properties.Resources.imgWrong16);
            lblIntrebare.Invalidate();
            return raspunsCorect;
        }

        /// <summary>
        /// Returneaza raspunsul utilizatorului
        /// </summary>
        public override string Raspuns
        {
            get
            {
                return txtRaspuns.Text;
            }
        }
        /// <summary>
        /// Seteaza starea butoanelor
        /// </summary>
        /// <param name="state">Starea "Enabled" a butoanelor</param>
        [Obsolete("Folosim Visible, pentru ca avem doar un control de tip TestGroupBox afisat la un moment dat")]
        public override void SetControlsState(bool state)
        {
            txtRaspuns.Enabled = state;
            if (state) // resetam imaginea doar cand creeam. incepe testul
                lblIntrebare.Image = null;
        }

        private void IntrebareGroupBox_SizeChanged(object sender, EventArgs e)
        {
            if (Parent == null)
                return;

            MaximumSize = new System.Drawing.Size(Parent.Width - 20, 600);
            lblIntrebare.MaximumSize = new System.Drawing.Size(Parent.Width - 30, 600);
        }
    }
}