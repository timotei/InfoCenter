// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
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
