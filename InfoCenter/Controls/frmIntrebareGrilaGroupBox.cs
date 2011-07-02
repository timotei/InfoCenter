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
using System;
using InfoCenter.Classes;

namespace InfoCenter.Controls
{
    public sealed partial class FrmIntrebareGrilaGroupBox : TestGroupBox
    {
        /// <summary>
        /// Nr crt-ul intrebarii
        /// </summary>
        public override int NrCrt { get; set; }
        /// <summary>
        /// Intrebarea asociata groupBox-ului
        /// </summary>
        public override IntrebareTest Intrebare
        {
            get { return IntrebareGrila; }
            set { IntrebareGrila = (value as IntrebareGrila); }
        }

        public IntrebareGrila IntrebareGrila { get; set; }

        public FrmIntrebareGrilaGroupBox()
        {
            InitializeComponent();
            Intrebare = null;
        }

        public FrmIntrebareGrilaGroupBox(IntrebareTest intrebare)
        {
            InitializeComponent();
            Intrebare = intrebare;
            if (Intrebare == null)
                return;

            lblIntrebare.Text = Intrebare.Intrebare;
            groupBox.Text = "Întrebarea nr. ";
            radioButton1.Text = IntrebareGrila.Raspuns1;
            radioButton2.Text = IntrebareGrila.Raspuns2;
            radioButton3.Text = IntrebareGrila.Raspuns3;
            radioButton4.Text = IntrebareGrila.Raspuns4;
        }
        /// <summary>
        /// Seteaza numarul intrebarii
        /// </summary>
        /// <param name="nr">Nr intrebarii</param>
        public override void SetIntrebareNr(int nr)
        {
            groupBox.Text = "Întrebarea nr. " + nr;
        }

        /// <summary>
        /// Valideaza raspunsurile si marcheaza cele corecte/incorecte
        /// <param name="markOnForm">Adevarat daca se doreste marcarea pe forma a raspunsului</param>
        /// </summary>
        public override bool ValidateRaspuns(bool markOnForm)
        {
            if (Intrebare == null)
                return false;
            RadioButton correctRadioButton =
                (tableLayoutPanel1.Controls["radioButton" + Intrebare.RaspunsCorect] as RadioButton);

            if (correctRadioButton != null)
            {
                if (!markOnForm)
                {
                    return correctRadioButton.Checked;
                }

                if (correctRadioButton.Checked) // raspuns corect
                {
                    SetButtonCorrect(correctRadioButton);
                    return true;
                }

                SetButtonCorrect(correctRadioButton);
            }

            if (radioButton1.Checked)
            {
                SetButtonIncorrect(radioButton1);
                return false;
            }

            if (radioButton2.Checked)
            {
                SetButtonIncorrect(radioButton2);
                return false;
            }

            if (radioButton3.Checked)
            {
                SetButtonIncorrect(radioButton3);
                return false;
            }

            if (radioButton4.Checked)
            {
                SetButtonIncorrect(radioButton4);
                return false;
            }

            return false;
        }
        /// <summary>
        /// Seteaza starea si imaginea butonului radio: corect
        /// </summary>
        private static void SetButtonCorrect(RadioButton radioButton)
        {
            radioButton.Image = Properties.Resources.imgOk16;
            radioButton.ForeColor = System.Drawing.Color.Green;
            radioButton.Text = "     " + radioButton.Text;
            radioButton.Invalidate();
        }
        /// <summary>
        /// Seteaza starea si imaginea butonului radio: incorecta
        /// </summary>
        private static void SetButtonIncorrect(RadioButton radioButton)
        {
            radioButton.Image = Properties.Resources.imgWrong16;
            radioButton.ForeColor = System.Drawing.Color.Red;
            radioButton.Text = "     " + radioButton.Text;
            radioButton.Invalidate();
        }
        /// <summary>
        /// Returneaza raspunsul selectat
        /// </summary>
        public override string Raspuns
        {
            get
            {
                if (radioButton1.Checked) return "1";
                if (radioButton2.Checked) return "2";
                if (radioButton3.Checked) return "3";
                if (radioButton4.Checked) return "4";
                return "-";
            }
        }

        /// <summary>
        /// Seteaza starea butoanelor
        /// </summary>
        /// <param name="state">Starea "Enabled" a butoanelor</param>
        [Obsolete("Folosim Visible, pentru ca avem doar un control de tip TestGroupBox afisat la un moment dat")]
        public override void SetControlsState(bool state)
        {
            radioButton1.Enabled = radioButton2.Enabled = radioButton3.Enabled = radioButton4.Enabled = state;

            radioButton1.ForeColor = radioButton2.ForeColor = radioButton3.ForeColor =
                radioButton4.ForeColor = System.Drawing.Color.Black;

            if (state)
                radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = radioButton4.Checked = false;
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