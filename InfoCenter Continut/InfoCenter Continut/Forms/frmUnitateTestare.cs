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
using Telerik.WinControls;

namespace InfoCenter.Forms
{
    public partial class FrmUnitateTestare : RadForm
    {
        /// <summary>
        /// Unitatea testare asociata formei
        /// </summary>
        public UnitateTestare UnitateTestare { get; set; }
        /// <summary>
        /// Id-ul problemei asociate
        /// </summary>
        public int IdProblema { get; set; }

        public FrmUnitateTestare(UnitateTestare unitate, int idproblema)
        {
            InitializeComponent();
            UnitateTestare = unitate;
            IdProblema = idproblema;
            SetUnitateTestareInformation();
        }

        /// <summary>
        /// Seteaza informatiile despre unitate pe forma
        /// </summary>
        public void SetUnitateTestareInformation()
        {
            if (UnitateTestare == null)
                return;

            txtNumeTest.Text = UnitateTestare.Nume;
            txtDateIesire.Text = UnitateTestare.DateIntrare;
            txtDateIntrare.Text = UnitateTestare.DateIntrare;
        }

        /// <summary>
        /// Returneaza 
        /// </summary>
        /// <returns></returns>
        private UnitateTestare GetUnitateTestare()
        {
            if (txtNumeTest.Text.Length == 0 || txtDateIesire.Text.Length == 0 || txtDateIntrare.Text.Length == 0)
            {
                Messages.ShowMessageBox(Messages.VALUES_UNSPECIFIED, "error");
                return null;
            }

            int id;
            if (UnitateTestare == null)
                id = ResourcesHandler.Instance.GetNextAvailableUnitateTestareId();
            else
                id = UnitateTestare.Id;

            return new UnitateTestare(id, IdProblema, txtNumeTest.Text, txtDateIntrare.Text, txtDateIesire.Text);
        }

        private void radButton2_Click(object sender, System.EventArgs e)
        {
            UnitateTestare = GetUnitateTestare();
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void radButton1_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}