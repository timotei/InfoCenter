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
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using InfoCenter.Classes;
using InfoCenter.Handlers;
using InfoCenter.Util;
using Telerik.WinControls;

namespace InfoCenter
{
    public partial class MainForm
    {
        /// <summary>
        /// Lista temporara de modificari aduse continutului: Intrebari Test
        /// </summary>
        private static List<ContinutUpdate<IntrebareTest>> _intrebariTestContinut = new List<ContinutUpdate<IntrebareTest>>();
        /// <summary>
        /// Lista temporara de modificari aduse continutului: Intrebari Grila
        /// </summary>
        private static List<ContinutUpdate<IntrebareGrila>> _intrebariGrilaContinut = new List<ContinutUpdate<IntrebareGrila>>();
        /// <summary>
        /// Lista temporara de modificari aduse continutului: Unitati Testare
        /// </summary>
        private static List<ContinutUpdate<UnitateTestare>> _unitatiTestareContinut = new List<ContinutUpdate<UnitateTestare>>();

        /// <summary>
        /// Seteaza tooltip-urile pentru fiecare buton.
        /// </summary>
        private void SetupToolTips()
        {
            btnAdaugaProblema.ButtonElement.ToolTipText = "Adaugă problema în listă ca şi nod al tipului selectat.";
            btnAdaugaTest.ButtonElement.ToolTipText = "Adaugă testul grila în listă ca şi nod al tipului selectat.";

            btnAddIntrebare.ToolTipTextNeeded += BtnAddIntrebareToolTipTextNeeded;
            btnModifyIntrebare.ButtonElement.ToolTipText = "Modifică întrebarea selectată.";
            btnDeleteIntrebare.ButtonElement.ToolTipText = "Şterge întrebarea selectată.";

            btnBackup.ButtonElement.ToolTipText = "Creează o copie de siguranţă a lecţiilor, problemelor si testelor.";
            btnOpenContinut.ButtonElement.ToolTipText = "Deschide dosarul care conţine lecţiile şi problemele.";
            btnRestoreBackup.ButtonElement.ToolTipText = "Restaurează ultima copie de siguranţă, dacă există.";
            btnReloadInfo.ButtonElement.ToolTipText = "Se încarcă informaţiile de pe disc şi se afişează pe formă.";
            btnSaveModificari.ButtonElement.ToolTipText = "Salvează modificările făcute întregului conţiunt.";

            btnCautaLectie.ButtonElement.ToolTipText = "Afişează o fereastră pentru a selecta fişierul lecţiei.";
            btnCautaProblemeAsociate.ButtonElement.ToolTipText = "Afişează o fereastră pentru a selecta problemele asociate lecţiei.";
            btnCautaTesteGrilaAsociate.ButtonElement.ToolTipText = "Afişează o fereastră pentru a selecta testele grila asociate lecţiei.";

            btnLectieNoua.ButtonElement.ToolTipText = "Iniţializează câmpurile pentru a adăuga o nouă lecţie.";
            btnProblemaNoua.ButtonElement.ToolTipText = "Iniţializează câmpurile pentru a adăuga o nouă problemă.";
            btnTestNou.ButtonElement.ToolTipText = "Iniţializează câmpurile pentru a adăuga un nou test.";

            btnPrevizualizeaza.ButtonElement.ToolTipText = "Afişează o fereastră pentru a previzualiza lecţia.";

            btnSaveModifLectie.ButtonElement.ToolTipText = "Salvează modificările făcute lecţiei selectate. Dacă nu este nici una selectată o va adăuga în listă.";
            btnSaveModifProblema.ButtonElement.ToolTipText = "Salvează modificările făcute probleme selectate. Dacă nu este nici una selectată o va adăuga în listă.";
            btnSaveModifTest.ButtonElement.ToolTipText = "Salvează modificările făcute testului selectat. Dacă nu este nici unul selectat îl va adăuga în listă.";

            btnStergeLectie.ButtonElement.ToolTipText = "Şterge lecţia selectată.";
            btnStergeProblema.ButtonElement.ToolTipText = "Şterge problema selectată.";
            btnStergeTest.ButtonElement.ToolTipText = "Şterge testul selectat.";
        }

        private void BtnAddIntrebareToolTipTextNeeded(object sender, ToolTipTextNeededEventArgs e)
        {
            e.ToolTipText = "Adaugă o întrebare în lista întrebărilor testului curent.";
        }

        /// <summary>
        /// Seteaza un status in status bar si imaginea corespunzatoare tipului
        /// </summary>
        /// <param name="statusString">Textul de setat</param>
        /// <param name="statusType">Tipul mesajului (ok,warn,error)</param>
        private void SetStatus(string statusString, string statusType)
        {
            radLabelStatus.Text = (statusString.Length != 0) ? "\t" + statusString : "Stare program.";

            Image image;
            switch (statusType.ToLower())
            {
                case "ok":
                    image = Properties.Resources.imgOk16;
                    break;
                case "warn":
                    image = Properties.Resources.imgAlert16;
                    break;
                case "error":
                    image = Properties.Resources.imgError16;
                    break;
                default:
                    image = null;
                    break;
            }
            radLabelStatus.Image = image;
            radLabelStatus.ImageAlignment = ContentAlignment.MiddleLeft;
        }

        /// <summary>
        /// Valideaza textul din TextBox-ul specificat.
        /// <param name="textBox">TextBox-ul care se va valida</param>
        /// <param name="validateNumber">Adevarat daca se valideaza pentru numere</param>
        /// </summary>
        private bool ValidateTextBoxText(TextBox textBox, bool validateNumber)
        {
            if (textBox.Text.Length == 0)
                return true;

            textBox.Text = textBox.Text.Trim();
            while (textBox.Text.Contains(",,"))
                textBox.Text = textBox.Text.Replace(",,", ",");

            while (textBox.Text.StartsWith(","))
                textBox.Text = textBox.Text.Substring(1);

            while (textBox.Text.EndsWith(","))
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);

            if (validateNumber)
                foreach (char c in txtProblemeAsociate.Text)
                    if (!Char.IsDigit(c) && c != ',')
                    {
                        errorProvider.SetError(txtProblemeAsociate, Messages.INCORRECT_VALUE);
                        return false;
                    }
            return true;
        }

        /// <summary>
        /// Reincarca baza de date si fisierele si afiseaza informatiile pe forma
        /// </summary>
        private void ReloadInfo()
        {
            ContinutHandler.Instance.IntrebariGrilaContinut.Clear();
            ContinutHandler.Instance.IntrebariTestContinut.Clear();
            if (ContinutHandler.Instance.LectiiContinut != null)
                ContinutHandler.Instance.LectiiContinut.Clear();
            ContinutHandler.Instance.ProblemeContinut.Clear();
            ContinutHandler.Instance.TesteContinut.Clear();
            ContinutHandler.Instance.TipuriContinut.Clear();
            ContinutHandler.Instance.UnitatiTestareContinut.Clear();
            LoadingThread();
            LoadingFinished();
            Messages.ShowMessageBox(Messages.BACKUP_RELOADED);
        }
    }
}