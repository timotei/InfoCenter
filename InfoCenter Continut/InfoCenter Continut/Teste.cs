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
using System.Linq;
using System.Windows.Forms;
using InfoCenter.Classes;
using InfoCenter.Controls;
using InfoCenter.Forms;
using InfoCenter.Handlers;
using InfoCenter.Util;
using Telerik.WinControls.UI;
using Res = InfoCenter.Handlers.ResourcesHandler;

namespace InfoCenter
{
    partial class MainForm
    {
        #region Intrebari test
        /// <summary>
        /// Adauga o intrebare la testul selectat
        /// </summary>
        private void AddIntrebareTest(string type)
        {
            int idTest;
            if (Res.Instance.SelectedTest == null)
                idTest = Res.Instance.GetNextAvailableTestId();
            else
                idTest = Res.Instance.SelectedTest.Id;

            FrmIntrebare window;
            switch (type)
            {
                case "grila":
                    window = new FrmIntrebareGrila(null, idTest);
                    break;
                case "test":
                    window = new FrmIntrebareTest(null, idTest);
                    break;
                default:
                    return;
            }

            if (window.ShowDialog() == DialogResult.OK && window.Intrebare != null)
            {
                IntrebareTest intrebare;
                switch (type)
                {
                    case "grila":
                        intrebare = (IntrebareGrila)window.Intrebare;
                        listaIntrebariTest.Items.Add(intrebare);
                        Res.Instance.IdsIntrebariGrila.Add(intrebare.Id);
                        _intrebariGrilaContinut.Add(
                    new ContinutUpdate<IntrebareGrila>((IntrebareGrila)intrebare, ContinutUpdateType.ADD));
                        break;
                    case "test":
                        intrebare = window.Intrebare;
                        listaIntrebariTest.Items.Add(intrebare);
                        Res.Instance.IdsIntrebari.Add(intrebare.Id);
                        _intrebariTestContinut.Add(
                    new ContinutUpdate<IntrebareTest>(intrebare, ContinutUpdateType.ADD));
                        break;
                }
            }
        }

        /// <summary>
        /// Modifica informatiile intrebarii selectate
        /// </summary>
        private void ModifyIntrebareTest()
        {
            if (listaIntrebariTest.SelectedItem == null)
            {
                Messages.ShowMessageBox(Messages.NO_INTREBARE_SELECTED, "warn");
                SetStatus(Messages.NO_INTREBARE_SELECTED, "warn");
                return;
            }

            IntrebareTest selectedIntrebare = (IntrebareTest)listaIntrebariTest.SelectedItem;

            if (selectedIntrebare == null)
                return;

            FrmIntrebare window;
            if (listaIntrebariTest.SelectedItem.GetType() == typeof(IntrebareGrila))
            {
                window = new FrmIntrebareGrila((IntrebareGrila)selectedIntrebare, selectedIntrebare.IdTest);
            }
            else if (listaIntrebariTest.SelectedItem.GetType() == typeof(IntrebareTest))
            {
                window = new FrmIntrebareTest(selectedIntrebare, selectedIntrebare.IdTest);
            }
            else
                return;

            if (window.ShowDialog() == DialogResult.OK && window.Intrebare != null)
            {
                IntrebareTest intrebare;
                if (window.GetType() == typeof(FrmIntrebareGrila))
                {
                    intrebare = (IntrebareGrila)window.Intrebare;
                    listaIntrebariTest.Items[listaIntrebariTest.SelectedIndex] = intrebare;
                    if (Res.Instance.SelectedTest != null)
                        _intrebariGrilaContinut.Add(new ContinutUpdate<IntrebareGrila>(
                                             (window.Intrebare as IntrebareGrila), ContinutUpdateType.MODIFY));
                }
                else if (window.GetType() == typeof(FrmIntrebareTest))
                {
                    intrebare = window.Intrebare;
                    listaIntrebariTest.Items[listaIntrebariTest.SelectedIndex] = intrebare;
                    if (Res.Instance.SelectedTest != null)
                        _intrebariTestContinut.Add(new ContinutUpdate<IntrebareTest>(
                             window.Intrebare, ContinutUpdateType.MODIFY));
                }
            }
        }

        /// <summary>
        /// Sterge intrebarea selectata
        /// </summary>
        private void DeleteIntrebareTest()
        {
            if (listaIntrebariTest.SelectedItem == null)
            {
                Messages.ShowMessageBox(Messages.NO_INTREBARE_SELECTED, "warn");
                SetStatus(Messages.NO_INTREBARE_SELECTED, "warn");
                return;
            }

            if (listaIntrebariTest.SelectedItem.GetType() == typeof(IntrebareGrila))
            {
                if (Res.Instance.SelectedTest != null)
                    _intrebariGrilaContinut.Add(new ContinutUpdate<IntrebareGrila>(
                        (listaIntrebariTest.SelectedItem as IntrebareGrila), ContinutUpdateType.DELETE));
                Res.Instance.IdsIntrebariGrila.Remove(((IntrebareGrila)listaIntrebariTest.SelectedItem).Id);
            }
            else if (listaIntrebariTest.SelectedItem.GetType() == typeof(IntrebareTest))
            {
                if (Res.Instance.SelectedTest != null)
                    _intrebariTestContinut.Add(new ContinutUpdate<IntrebareTest>(
                        (listaIntrebariTest.SelectedItem as IntrebareTest), ContinutUpdateType.DELETE));
                Res.Instance.IdsIntrebari.Remove(((IntrebareTest)listaIntrebariTest.SelectedItem).Id);
            }

            listaIntrebariTest.Items.Remove(listaIntrebariTest.SelectedItem);
        }
        #endregion
        /// <summary>
        /// Seteaza informatiile despre testul selectat
        /// </summary>
        private void SetTestInformation()
        {
            if (Res.Instance.SelectedTest == null)
                return;
            Test test = Res.Instance.SelectedTest;

            txtTitluTest.Text = test.Titlu;
            comboBoxTipTest.Text = test.Tip;
            comboBoxDificultateTest.Text = test.Dificultate.ToString();
            txtPuncteOficiuTest.Text = test.PunctajOficiu.ToString();

            btnStergeTest.Enabled = true;
            btnModifyIntrebare.Enabled = false;
            btnDeleteIntrebare.Enabled = false;

            listaIntrebariTest.Items.Clear();
            foreach (IntrebareTest intrebare in test.Intrebari)
            {
                listaIntrebariTest.Items.Add(intrebare);
            }

            foreach (var intrebare in _intrebariGrilaContinut)
                Res.Instance.IdsIntrebariGrila.Remove(intrebare.CustomStruct.Id);
            foreach (var intrebare in _intrebariTestContinut)
                Res.Instance.IdsIntrebari.Remove(intrebare.CustomStruct.Id);
            _intrebariGrilaContinut.Clear();
            _intrebariTestContinut.Clear();

            errorProvider.Clear();
        }
        /// <summary>
        /// Salveaza modificarile facute testului
        /// </summary>
        private void SaveChangesTest()
        {
            if (Res.Instance.SelectedTest == null)
            {
                if (Messages.ShowMessageBox(Messages.ADD_MODIFY_NEW_TEST_ARRAY[0],
                    Messages.ADD_MODIFY_NEW_TEST_ARRAY[1], "question") == DialogResult.No)
                    return;

                AddTest();
                return;
            }

            CustomTreeNode<Test> newNode = GetTestTreeNode(true);
            if (newNode == null || newNode.CustomStruct == null)
                return;
            Test newTest = GetTestTreeNode(true).CustomStruct;

            CreateParentNode<Test>(treeViewTeste, newTest.Tip);
            if (treeViewTeste.SelectedNode != null)
            {
                CustomTreeNode<Test> selectedNode = ((CustomTreeNode<Test>)treeViewTeste.SelectedNode);
                selectedNode.CustomStruct = newTest;
                treeViewTeste.SelectedNode.Text = newTest.Titlu;

                // s-a schimbat tipul
                if (!Res.Instance.SelectedTest.Tip.Equals(newTest.Tip))
                {
                    RadTreeNode parentNode = selectedNode.Parent; // Nodul tipului
                    if (parentNode != null)
                    {
                        parentNode.Nodes.Remove(selectedNode);
                        if (parentNode.Nodes.Count == 0)
                            treeViewTeste.Nodes.Remove(parentNode);
                    }
                    treeViewTeste.Nodes[newTest.Tip].Nodes.Add(newNode);
                }
            }

            Res.Instance.SelectedTest = newTest;
            ContinutHandler.Instance.IntrebariTestContinut.AddRange(_intrebariTestContinut);
            ContinutHandler.Instance.IntrebariGrilaContinut.AddRange(_intrebariGrilaContinut);
            _intrebariGrilaContinut.Clear();
            _intrebariTestContinut.Clear();
            ContinutHandler.Instance.TesteContinut.Add(new ContinutUpdate<Test>(newTest,
                ContinutUpdateType.MODIFY));
            SetStatus(Messages.TEST_SAVED, "ok");
        }
        /// <summary>
        /// Actualizeaza intrebarile in baza de date
        /// </summary>
        private void UpdateTesteGrilaIntrebariContinut(Test test)
        {
            // intrebari test
            ContinutHandler.Instance.IntrebariTestContinut.AddRange(_intrebariTestContinut);
            _intrebariTestContinut.Clear();

            // intrebari grila
            ContinutHandler.Instance.IntrebariGrilaContinut.AddRange(_intrebariGrilaContinut);
            _intrebariGrilaContinut.Clear();
        }

        /// <summary>
        /// Adauga un nou test grila in lista testelor
        /// </summary>
        private void AddTest()
        {
            if (Res.Instance.SelectedTest != null)
            {
                Messages.ShowMessageBox(Messages.TEST_ALREADY_ADDED, "warn");
                SetStatus(Messages.TEST_ALREADY_ADDED, "warn");
                return;
            }

            CustomTreeNode<Test> testNode = GetTestTreeNode(false);
            if (testNode == null)
                return;
            Test test = testNode.CustomStruct;
            if (test == null)
                return;

            Res.Instance.IdsTeste.Add(test.Id);
            Res.Instance.ListaTeste.Add(test);

            CreateParentNode<Test>(treeViewTeste, test.Tip);
            treeViewTeste.Nodes[test.Tip].Nodes.Add(testNode);
            ContinutHandler.Instance.TesteContinut.Add(new ContinutUpdate<Test>(test, ContinutUpdateType.ADD));

            UpdateTesteGrilaIntrebariContinut(test);
            SetNewTest();

            SetStatus(Messages.TEST_ADDED, "ok");
        }
        /// <summary>
        /// Creaza un nod in lista specificata pentru tipul specificat
        /// </summary>
        /// <param name="treeView">Arborele in care va crea nodul</param>
        /// <param name="tip"></param>
        private void CreateParentNode<T>(RadTreeView treeView, string tip) where T : class
        {
            if (treeView.Nodes[tip] == null)
            {
                treeView.Nodes.Add(new CustomTreeNode<T>(tip, null, true));
            }
        }
        /// <summary>
        /// Reseteaza campurile pentru un test grila nou
        /// </summary>
        private void SetNewTest()
        {
            Res.Instance.SelectedTest = null;

            txtPuncteOficiuTest.Text = txtTitluTest.Text = "";
            comboBoxDificultateTest.Text = "1";
            comboBoxTipTest.Text = "<nespecificat>";
            listaIntrebariTest.Items.Clear();
            treeViewTeste.SelectedNode = null;
            treeViewTeste.Refresh();
            errorProvider.Clear();

            btnStergeTest.Enabled = false;
            btnModifyIntrebare.Enabled = false;
            btnDeleteIntrebare.Enabled = false;

            foreach (var intrebare in _intrebariGrilaContinut)
                Res.Instance.IdsIntrebariGrila.Remove(intrebare.CustomStruct.Id);
            foreach (var intrebare in _intrebariTestContinut)
                Res.Instance.IdsIntrebari.Remove(intrebare.CustomStruct.Id);
            _intrebariGrilaContinut.Clear();
            _intrebariTestContinut.Clear();
        }
        /// <summary>
        /// Sterge testul grila selectat
        /// </summary>
        private void DeleteSelectedTest()
        {
            if (treeViewTeste.SelectedNode == null)
            {
                Messages.ShowMessageBox(Messages.NO_TEST_SELECTED_ARRAY[0], "warn");
                SetStatus(Messages.NO_TEST_SELECTED_ARRAY[0], "warn");
                return;
            }
            var node = (CustomTreeNode<Test>)treeViewTeste.SelectedNode;
            if (node.IsCustomParent || (node.CustomStruct == null) || (node.Parent == null))
                return;


            if (node.Parent.Nodes.Count == 1) // daca se sterge testul, tipul ramane fara subnoduri
            {
                treeViewTeste.Nodes.Remove(node.Parent);
                node.Parent.Nodes.Remove(node);
            }
            else
                node.Parent.Nodes.Remove(node);

            treeViewTeste.Refresh();

            Res.Instance.RemoveTest(node.CustomStruct);
            SetStatus(Messages.TEST_DELETED, "ok");
            SetNewTest();
        }
        /// <summary>
        /// Returneaza nodul care contine Testul Grila de pe forma
        /// </summary>
        /// <param name="save">Adevarat daca se salveaza modificarile</param>
        /// <returns></returns>
        private CustomTreeNode<Test> GetTestTreeNode(bool save)
        {
            int id;
            if (save)
            {
                if (Res.Instance.SelectedTest == null)
                    return null;
                id = Res.Instance.SelectedTest.Id;
            }
            else
                id = Res.Instance.GetNextAvailableTestId();

            if (txtTitluTest.Text.Length == 0)
            {
                errorProvider.SetError(txtTitluTest, Messages.TITLE_UNSPECIFIED);
                return null;
            }
            errorProvider.SetError(txtTitluTest, "");

            if (comboBoxTipTest.Text.Equals("<nespecificat>") || comboBoxTipTest.Text.Length == 0)
            {
                errorProvider.SetError(comboBoxTipTest, Messages.TYPE_UNSPECIFIED);
                return null;
            }
            errorProvider.SetError(comboBoxTipTest, "");

            int punctajOficiu;
            int.TryParse(txtPuncteOficiuTest.Text, out punctajOficiu);
            txtPuncteOficiuTest.Text = punctajOficiu.ToString();

            int dificultate;
            int.TryParse(comboBoxDificultateTest.Text, out dificultate);
            if (comboBoxDificultateTest.Text.Equals("<nespecificat>") || (dificultate == 0))
            {
                errorProvider.SetError(comboBoxDificultateTest, Messages.INCORRECT_VALUE);
                return null;
            }
            errorProvider.SetError(comboBoxDificultateTest, "");

            if (listaIntrebariTest.Items.Count == 0)
            {
                Messages.ShowMessageBox(Messages.NO_INTREBARI_EXIST, "warn");
                SetStatus(Messages.NO_INTREBARI_EXIST, "warn");
                return null;
            }

            Test test = new Test(id, txtTitluTest.Text, comboBoxTipTest.Text, dificultate,
                punctajOficiu, listaIntrebariTest.Items.Cast<IntrebareTest>().ToList());

            return new CustomTreeNode<Test>(test.Titlu, test, false);
        }
    }
}