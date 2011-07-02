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
using System.Linq;
using InfoCenter.Classes;
using InfoCenter.Controls;
using InfoCenter.Extensions;
using Telerik.WinControls.UI;
using Res = InfoCenter.Handlers.ResourcesHandler;

namespace InfoCenter
{
    public partial class MainForm
    {
        /// <summary>
        /// Adevarat daca sursa s-a modificat
        /// </summary>
        private bool _sourceTextModified = true;

        /// <summary>
        /// Delegat pentru setarea status-ului, din alte threaduri
        /// </summary>
        /// <param name="message">Mesajul de trimis</param>
        /// <param name="errorLevel">Nivelul de eroare</param>
        private delegate void SetStatusLabel(string message, int errorLevel);

        /// <summary>
        /// Adauga un item de tip continut in lista ultimelor accesari
        /// </summary>
        /// <param name="continut"></param>
        private void AddLastAccesItem(IContinut continut)
        {
            if (continut == null)
                return;

            if (ribbonBar.StartMenuRightColumnItems.FirstOrDefault(p => p.Text.Equals(continut.Titlu)) != null)
                return;

            RadMenuItem newItem = null;
            if (continut is Problema)
            {
                newItem = new CustomRadItem<Problema>(continut as Problema)
                              {
                                  Text = ((Problema)continut).Titlu,
                                  Name = ((Problema)continut).Titlu + ribbonBar.StartMenuRightColumnItems.Count + 1,
                                  KeyTip = "problema"
                              };
            }
            else if (continut is Test)
            {
                newItem = new CustomRadItem<Test>(continut as Test)
                              {
                                  Text = ((Test)continut).Titlu,
                                  Name = ((Test)continut).Titlu + ribbonBar.StartMenuRightColumnItems.Count + 1,
                                  KeyTip = "test"
                              };
            }
            else if (continut is Lectie)
            {
                newItem = new CustomRadItem<Lectie>(continut as Lectie)
                              {
                                  Text = ((Lectie)continut).Titlu,
                                  Name = ((Lectie)continut).Titlu + ribbonBar.StartMenuRightColumnItems.Count + 1,
                                  KeyTip = "lectie"
                              };
            }

            if (newItem != null)
            {
                newItem.Click += LastMenuItemClick;
                ribbonBar.StartMenuRightColumnItems.Insert(0, newItem);
            }

            while (ribbonBar.StartMenuRightColumnItems.Count >= 10)
            {
                ribbonBar.StartMenuRightColumnItems.RemoveAt(ribbonBar.StartMenuRightColumnItems.Count - 1);
            }
            ribbonBar.Invalidate();
        }

        private void LastMenuItemClick(object sender, EventArgs e)
        {
            if (!(sender is RadMenuItem))
                return;

            if (sender is CustomRadItem<Problema>)
            {
                Res.Instance.SelectedProblema = (sender as CustomRadItem<Problema>).CustomStruct;
                SetProblemaInformation();
            }
            else if (sender is CustomRadItem<Test>)
            {
                Res.Instance.SelectedTest = (sender as CustomRadItem<Test>).CustomStruct;
                SetTestInformation();
            }
            else if (sender is CustomRadItem<Lectie>)
            {
                Res.Instance.SelectedLectie = (sender as CustomRadItem<Lectie>).CustomStruct;
                SetLectieInformation();
            }
        }

        /// <summary>
        /// Seteaza imaginea in functie de dificultatea specificata intr-un label (0-3)
        /// </summary>
        /// <param name="buttonLabel">Label-ul pentru care se va seta imaginea</param>
        /// <param name="difficulty">Dificultatea</param>
        private void SetDifficultyImage(RadLabelElement buttonLabel, int difficulty)
        {
            SetStatusLabelState("", 0);
            switch (difficulty)
            {
                case 1:
                    buttonLabel.Image = Properties.Resources._1_star_rating;
                    break;
                case 2:
                    buttonLabel.Image = Properties.Resources._2_star_rating;
                    break;
                case 3:
                    buttonLabel.Image = Properties.Resources._3_star_rating;
                    break;
                default:
                    buttonLabel.Image = Properties.Resources._0_star_rating;
                    break;
            }
        }

        /// <summary>
        /// Seteaza imaginea si label-ul potrivit starii curente (0=ok, 1=error, -1=warn)
        /// </summary>
        /// <param name="msg"> 0 = OK, 1 = Error, -1 = Warning</param>
        /// <param name="errorLevel"></param>
        private void SetStatusLabelState(string msg, int errorLevel)
        {
            toolStripStatus.Text = msg.Length == 0 ? "Stare program" : msg;

            switch (errorLevel)
            {
                case -1: // Warning
                    toolStripStatus.Image = Properties.Resources.imgAlert16;
                    break;
                case 0: // OK
                    toolStripStatus.Image = Properties.Resources.imgOk16;
                    break;
                case 1: //Error
                    toolStripStatus.Image = Properties.Resources.imgError16;
                    break;
                default:
                    toolStripStatus.Image = null;
                    break;
            }
        }
        /// <summary>
        /// Adauga unltimul sir de caractere cautat, in dropdown-ul de la comboBox
        /// </summary>
        /// <param name="comboBox">ComboBox-ul</param>
        private void AddSearchedBeforeItems(RadComboBoxElement comboBox)
        {
            if (comboBox.Text == null)
                return;

            foreach (RadComboBoxItem item in comboCautaProblema.Items)
                if (item.Text.Equals(comboBox.Text))
                    return;

            comboBox.Items.Add(new RadComboBoxItem(comboBox.Text));
        }

        /// <summary>
        /// Selecteaza tab-ul specificat (in ribbonBar si tabControlMain)
        /// </summary>
        /// <param name="tabName">tabName</param>
        private void SelectTab(string tabName)
        {
            if (tabName == null || tabControlMain.TabPages[tabName] == null)
                return;

            tabControlMain.SelectTab(tabName);
            int tabIndex = tabControlMain.TabPages.IndexOf(tabControlMain.TabPages[tabName]);

            ribbonBar.RibbonBarElement.TabStripElement.SelectedTab =
                ribbonBar.RibbonBarElement.TabStripElement.Items[tabIndex];
            SetStatusLabelState("", 2);
        }

        /// <summary>
        /// Verifica testele problemei
        /// </summary>
        /// <param name="checkedOnly">Adevarat daca se verifica doar cele bifate</param>
        private void VerificaTeste(bool checkedOnly)
        {
            // Cell[0] - Nume test, 
            // Cell[1] - CheckBox, 
            // Cell[2] - Verifica testul curent, 
            // Cell[3] - rezultate(Imagine)

            // sterge rezultatele existente
            foreach (var row in gridVerificare.Rows)
            {
                row.Cells[3].Value = "";
            }

            if (checkedOnly && gridVerificare.CountSelected() == 0)
                return;

            if (!UpdateCompilerData())
                return;

            int rowIndex = 0;
            foreach (var row in gridVerificare.Rows)
            {
                if (checkedOnly &&
                    gridVerificare.Rows[rowIndex].Cells[1].Value.ToString().ToLower().Equals("false"))
                    continue;

                UnitateTestare unitate = (row.Cells[0].Value as UnitateTestare);
                if (unitate == null)
                    return;

                VerificaDateIesire(unitate, rowIndex);

                rowIndex++;
                if (rowIndex >= gridVerificare.Rows.Count)
                    break;
            }
        }
    }
}