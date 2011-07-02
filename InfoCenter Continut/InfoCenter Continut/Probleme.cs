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
using System.IO;
using System.Windows.Forms;
using InfoCenter.Classes;
using InfoCenter.Controls;
using InfoCenter.Forms;
using InfoCenter.Handlers;
using InfoCenter.Util;
using Res = InfoCenter.Handlers.ResourcesHandler;

namespace InfoCenter
{
    partial class MainForm
    {

        /// <summary>
        /// Returneaza lista de probleme
        /// </summary>
        /// <param name="save">Adevarat daca se salveaza problema</param>
        /// <returns></returns>
        private CustomListViewItem<Problema> GetProblemaListView(bool save)
        {
            int id;
            if (save)
            {
                if (Res.Instance.SelectedProblema == null)
                    return null;

                id = Res.Instance.SelectedProblema.Id;
            }
            else
                id = Res.Instance.GetNextAvailableProblemaId();

            if (comboBoxTipProblema.Text.Equals("<nespecificat>") || comboBoxTipProblema.Text.Length == 0)
            {
                errorProvider.SetError(comboBoxTipProblema, Messages.TYPE_UNSPECIFIED);
                return null;
            }
            errorProvider.SetError(comboBoxTipProblema, "");

            if (txtTitluProblema.Text.Length == 0)
            {
                errorProvider.SetError(txtTitluProblema, Messages.TITLE_UNSPECIFIED);
                return null;
            }
            errorProvider.SetError(txtTitluProblema, "");

            ValidateTextBoxText(txtCuvinteCheieProblema, false);
            int difficulty;
            int.TryParse(comboBoxDificultateProblema.Text, out difficulty);
            if (difficulty < 1 || difficulty > 3)
            {
                errorProvider.SetError(comboBoxDificultateProblema, Messages.INCORRECT_VALUE);
                return null;
            }
            errorProvider.SetError(comboBoxDificultateProblema, "");

            Problema newProblema = new Problema(id, comboBoxTipProblema.Text, txtTitluProblema.Text,
                txtCerintaProblema.Text, difficulty, txtCuvinteCheieProblema.Text, Config.ProblemePath);

            return new CustomListViewItem<Problema>(newProblema.Titlu, newProblema);
        }
        /// <summary>
        /// Adauga problema in lista
        /// </summary>
        private void AddProblema()
        {
            if (Res.Instance.SelectedProblema != null)
            {
                Messages.ShowMessageBox(Messages.PROBLEMA_ALREADY_ADDED, "warn");
                SetStatus(Messages.PROBLEMA_ALREADY_ADDED, "warn");
                return;
            }

            CustomListViewItem<Problema> problema = GetProblemaListView(false);
            if (problema == null)
                return;

            problema.Group = listaProbleme.Groups[problema.CustomStruct.Tip];
            listaProbleme.Items.Add(problema);

            SaveProblemaFile();

            Res.Instance.IdsProbleme.Add(problema.CustomStruct.Id);
            Res.Instance.ListaProbleme.Add(problema.CustomStruct);

            ContinutHandler.Instance.ProblemeContinut.Add(new ContinutUpdate<Problema>(problema.CustomStruct,
                ContinutUpdateType.ADD));

            SetNewProblema();
            SetStatus(Messages.PROBLEMA_ADDED, "ok");
        }
        /// <summary>
        /// Initializeaza o noua problema si reseteaza campurile
        /// </summary>
        private void SetNewProblema()
        {
            txtTitluProblema.Text = txtCerintaProblema.Text = txtCuvinteCheieProblema.Text = "";
            comboBoxTipProblema.Text = "<nespecificat>";
            listaUnitatiTestare.Items.Clear();
            comboBoxDificultateProblema.Text = "1";
            lblCodSursaCPP.Text = "Nu";
            Res.Instance.SelectedCPPSource = "";
            Res.Instance.SelectedProblema = null;

            btnStergeProblema.Enabled = false;
            btnModifyUnitateTestare.Enabled = false;
            btnDeleteUnitateTestare.Enabled = false;

            listaProbleme.Refresh();
            _unitatiTestareContinut.Clear();
        }
        /// <summary>
        /// Salveaza fisierul cu codul sursa asociat problemei
        /// </summary>
        private void SaveProblemaFile()
        {
            if (Res.Instance.SelectedProblema == null)
                return;

            string path = Config.ProblemePath + Res.Instance.SelectedProblema.Id;
            string cppPath = path + ".cpp";

            try
            {
                if (Res.Instance.SelectedCPPSource.Length > 0)

                    using (StreamWriter sw = new StreamWriter(cppPath))
                    {
                        sw.Write(Res.Instance.SelectedCPPSource);
                        sw.Close();
                    }
                else
                    if (File.Exists(cppPath))
                        File.Delete(cppPath);
            }
            catch (Exception e)
            {
                ExceptionsHandler.Instance.AddException(e, Messages.ERROR_SAVE_FILE);
            }
        }

        /// <summary>
        /// Salveaza schimbarile facute la problema
        /// </summary>
        private void SaveChangesProblema()
        {
            CustomListViewItem<Problema> newProblema = GetProblemaListView(true);
            if (newProblema == null)
                return;

            if (listaProbleme.SelectedIndices.Count != 1)
            {
                if (Messages.ShowMessageBox(Messages.ADD_MODIFY_NEW_PROBLEMA_ARRAY[0],
                   Messages.ADD_MODIFY_NEW_PROBLEMA_ARRAY[1], "question") == DialogResult.Yes)
                    AddProblema();

                return;
            }

            newProblema.Group = listaProbleme.Groups[newProblema.CustomStruct.Tip] ??
                                listaProbleme.Groups["<nespecificat"];

            listaProbleme.Items[listaProbleme.SelectedIndices[0]] = newProblema;
            Res.Instance.SelectedProblema = newProblema.CustomStruct;
            SaveProblemaFile();
            SetNewProblema();

            ContinutHandler.Instance.UnitatiTestareContinut.AddRange(_unitatiTestareContinut);
            _unitatiTestareContinut.Clear();
            ContinutHandler.Instance.ProblemeContinut.Add(new ContinutUpdate<Problema>(newProblema.CustomStruct,
                ContinutUpdateType.MODIFY));
            SetStatus(Messages.PROBLEMA_SAVED, "ok");
        }
        /// <summary>
        /// Sterge Problema selectata
        /// </summary>
        private void DeleteSelectedProblema()
        {
            if (listaProbleme.SelectedItems.Count != 1)
                return;

            listaProbleme.Items.Remove(listaProbleme.SelectedItems[0]);
            Res.Instance.RemoveProblema(Res.Instance.SelectedProblema);
            Res.Instance.SelectedProblema = null;
            SetNewProblema();
            SetStatus(Messages.PROBLEMA_DELETED, "ok");
        }
        /// <summary>
        /// Afiseaza o fereastra in care se poate modifica codul sursa. 
        /// </summary>
        /// <param name="source">Textul care contine codul sursa</param>
        /// <param name="lbl">Label-ul unde se va scrie daca exista sau nu cod sursa</param>
        /// <param name="highlighting">Tipul de highlighting(C++.NET)</param>
        private void ShowCodSursaWindow(ref string source, Label lbl, string highlighting)
        {
            FrmEditorCodSursa window = new FrmEditorCodSursa(source, highlighting);
            if (window.ShowDialog() == DialogResult.OK)
            {
                source = window.GetCurrentSourceCode();
                lbl.Text = (source.Length > 1 ? "Da" : "Nu");
            }
        }
        /// <summary>
        /// Seteaza informatiile 
        /// </summary>
        private void SetProblemaInformation()
        {
            if (Res.Instance.SelectedProblema == null)
                return;

            Problema problema = Res.Instance.SelectedProblema;
            comboBoxTipProblema.Text = problema.Tip;
            txtTitluProblema.Text = problema.Titlu;
            txtCerintaProblema.Text = problema.Cerinta;
            comboBoxDificultateProblema.Text = problema.Dificultate.ToString();
            txtCuvinteCheieProblema.Text = problema.CuvinteCheie;
            lblCodSursaCPP.Text = (problema.HasCPPSource ? "Da" : "Nu");
            
            btnStergeProblema.Enabled = true;
            btnModifyUnitateTestare.Enabled = false;
            btnDeleteUnitateTestare.Enabled = false;

            _unitatiTestareContinut.Clear();
            listaUnitatiTestare.Items.Clear();

            var unitati = Res.Instance.GetUnitatiTestareByProblema(problema.Id);            
            foreach (var unitate in unitati)
            {
                listaUnitatiTestare.Items.Add(unitate);
            }

            try
            {
                if (problema.HasCPPSource)
                    using (StreamReader sr = new StreamReader(problema.LocatieCPP))
                        Res.Instance.SelectedCPPSource = sr.ReadToEnd();
                else
                    Res.Instance.SelectedCPPSource = "";
            }
            catch (Exception e)
            {
                ExceptionsHandler.Instance.AddException(e, Messages.ERROR_LOAD_SOURCE_FILE);
            }
        }

        #region Unitati testare

        private void DeleteUnitateTestare()
        {
            if (listaUnitatiTestare.SelectedItems.Count == 0)
            {
                Messages.ShowMessageBox(Messages.NO_UNITATE_TESTARE_SELECTED, "warn");
                SetStatus(Messages.NO_UNITATE_TESTARE_SELECTED, "warn");
                return;
            }

            UnitateTestare unitate = listaUnitatiTestare.SelectedItems[0] as UnitateTestare;
            if (unitate == null)
                return;

            Res.Instance.IdsUnitatiTestare.Remove(unitate.Id);
            if (Res.Instance.SelectedProblema != null)
                _unitatiTestareContinut.Add(new ContinutUpdate<UnitateTestare>(unitate, ContinutUpdateType.DELETE));
            listaUnitatiTestare.Items.Remove(listaUnitatiTestare.SelectedItems[0]);
        }


        private void ModifyUnitateTestare()
        {
            if (listaUnitatiTestare.SelectedItems.Count == 0)
            {
                Messages.ShowMessageBox(Messages.NO_UNITATE_TESTARE_SELECTED, "warn");
                SetStatus(Messages.NO_UNITATE_TESTARE_SELECTED, "warn");
                return;
            }

            UnitateTestare unitate = listaUnitatiTestare.SelectedItems[0] as UnitateTestare;

            if (unitate == null)
                return;

            FrmUnitateTestare window = new FrmUnitateTestare(unitate, unitate.IdProblema);
            if (window.ShowDialog() == DialogResult.OK && window.UnitateTestare != null)
            {
                unitate = window.UnitateTestare;
                listaUnitatiTestare.Items[listaUnitatiTestare.SelectedIndices[0]] = unitate;
                if (Res.Instance.SelectedProblema != null)
                    _unitatiTestareContinut.Add(new ContinutUpdate<UnitateTestare>(unitate,
                        ContinutUpdateType.MODIFY));
            }
        }

        private void AddUnitateTestare()
        {
            int idProblema;
            if (Res.Instance.SelectedProblema == null)
                idProblema = Res.Instance.GetNextAvailableUnitateTestareId();
            else
                idProblema = Res.Instance.SelectedProblema.Id;

            FrmUnitateTestare window = new FrmUnitateTestare(null, idProblema);
            if (window.ShowDialog() == DialogResult.OK && window.UnitateTestare != null)
            {
                listaUnitatiTestare.Items.Add(window.UnitateTestare);
                _unitatiTestareContinut.Add(new ContinutUpdate<UnitateTestare>(window.UnitateTestare,
                    ContinutUpdateType.ADD));
            }
        }
        #endregion
    }
}
