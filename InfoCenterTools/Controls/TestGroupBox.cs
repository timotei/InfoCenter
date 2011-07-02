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
using InfoCenter.Classes;
using System;

namespace InfoCenter.Controls
{
    public abstract class TestGroupBox : UserControl, ITestGroupBox
    {
        /// <summary>
        /// Seteaza numarul intrebarii curente
        /// </summary>
        /// <param name="nr">Numarul intrebarii</param>
        public abstract void SetIntrebareNr(int nr);

        /// <summary>
        /// Valideaza raspunsul, marcheaza pe forma si returneaza rezultatul
        /// </summary>
        /// <param name="markOnForm">Adevarat daca se marcheaza rezultatul pe forma</param>
        public abstract bool ValidateRaspuns(bool markOnForm);

        /// <summary>
        /// Seteaza starea controalelor
        /// </summary>
        /// <param name="state">Starea Enabled</param>
        [Obsolete("Folosim Visible, pentru ca avem doar un control de tip TestGroupBox afisat la un moment dat")]
        public abstract void SetControlsState(bool state);
        /// <summary>
        /// Returneaza raspunsul utilizatorului
        /// </summary>
        public abstract string Raspuns
        {
            get;
        }

        /// <summary>
        /// Numarul groupBox-ului
        /// </summary>
        public abstract int NrCrt
        {
            get;
            set;
        }

        /// <summary>
        /// Intrebarea asociata cu acest group Box
        /// </summary>
        public abstract IntrebareTest Intrebare
        {
            get;
            set;
        }
    }
}
