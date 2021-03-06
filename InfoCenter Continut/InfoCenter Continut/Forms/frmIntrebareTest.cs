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
using InfoCenter.Classes;
using InfoCenter.Handlers;
using InfoCenter.Util;
namespace InfoCenter.Forms
{
    /// <summary>
    /// Afiseaza o forma pentru editare sau modificarea intrebarii
    /// </summary>
    public partial class FrmIntrebareTest : FrmIntrebare
    {
        /// <summary>
        /// Intrebarea asociata formei
        /// </summary>
        public override IntrebareTest Intrebare { get; set; }

        /// <summary>
        /// Id-ul testului caruia ii este asociata intrebarea
        /// </summary>
        public override int IdTest { get; set; }

        /// <summary>
        /// Seteaza informatiile despre intrebare pe forma
        /// </summary>
        public override void SetIntrebareInformation()
        {
            if (Intrebare == null)
                return;

            txtIntrebare.Text = Intrebare.Intrebare;
            txtPuncte.Text = Intrebare.Puncte.ToString();
            txtRaspunsCorect.Text = Intrebare.RaspunsCorect;
        }

        /// <summary>
        /// Returneaza Intrebarea de pe forma, formata din datele 
        /// introduse de utilizator
        /// </summary>
        /// <returns></returns>
        private IntrebareTest GetIntrebareTest()
        {
            int id;
            if (Intrebare == null)
                id = ResourcesHandler.Instance.GetNextAvailableIntrebareId();
            else
                id = Intrebare.Id;

            float puncte;
            float.TryParse(txtPuncte.Text, out puncte);
            if (txtIntrebare.Text.Length == 0 || txtRaspunsCorect.Text.Length == 0)
            {
                Messages.ShowMessageBox(Messages.VALUES_UNSPECIFIED, "error");
                return null;
            }

            IntrebareTest intrebare = new IntrebareTest(id, IdTest, txtIntrebare.Text, txtRaspunsCorect.Text, puncte);
            return intrebare;
        }
        public FrmIntrebareTest(IntrebareTest intrebare, int idtest)
        {
            InitializeComponent();

            Intrebare = intrebare;
            IdTest = idtest;
        }

        private void frmIntrebareTest_Load(object sender, System.EventArgs e)
        {
            SetIntrebareInformation();
        }

        private void btnSalveazaInchide_Click(object sender, System.EventArgs e)
        {
            Intrebare = GetIntrebareTest();
            if (Intrebare == null)
                return;

            ResourcesHandler.Instance.IdsIntrebari.Add(Intrebare.Id);
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void btnInchide_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}