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
using System.Threading;
using System.Windows.Forms;
using InfoCenter.Classes;
using InfoCenter.Controls;
using InfoCenter.Forms;
using InfoCenter.Handlers;
using InfoCenter.Util;
using Telerik.WinControls;

namespace InfoCenter
{
    public partial class MainForm : RadForm
    {
        /// <summary>
        /// Tabul principal selectat
        /// </summary>
        private int _selectedTab; // 0- Tablou de control, 1 Lectii, 2 Probleme 3 Teste

        public MainForm()
        { 
            Thread loadingThread = new Thread(LoadingThread) {IsBackground = true, Name ="loading"};
            loadingThread.Start();

            InitializeComponent();
            SetupToolTips();

            // daca nu s-a terminat incarcarea astept dupa ea
            loadingThread.Join();

            LoadingFinished();
            Splasher.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ContinutHandler.Instance.HasModified())
                if (Messages.ShowMessageBox(Messages.SAVE_CHANGES_ARRAY[0], Messages.SAVE_CHANGES_ARRAY[1],
                    "question") == DialogResult.Yes)
                    SaveChanges();

            Logging.Instance.CloseLog();
            DatabaseHandler.Instance.CloseDBAcess();
        }

        #region Main form

        #region KeyDown events
        private void treeViewTeste_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                DeleteSelectedTest();
        }

        private void treeViewLectii_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                DeleteSelectedLectie();
        }


        private void ListaIntrebariTestKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                DeleteIntrebareTest();
        }

        private void listaProbleme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                DeleteSelectedProblema();
        }
        #endregion
        #region GotFocus events

        private void documentProbleme_GotFocus(object sender, EventArgs e)
        {
            SetStatus("", "");
        }

        private void documentLectii_GotFocus(object sender, EventArgs e)
        {
            SetStatus("", "");
        }
        #endregion
        #region Click events
        private void btnSaveModificari_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }
        private void btnReloadInfo_Click(object sender, EventArgs e)
        {
            ReloadInfo();
        }
        private void btnOpenContinut_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Config.AppDataPath);
            }
            catch (Exception ex)
            {
                ExceptionsHandler.Instance.AddException(ex, Messages.ERROR_OPEN_CONTINUT_FOLDER);
            }
        }

        private void DocumentLectiiClick(object sender, EventArgs e)
        {
            menuSave.Text = "Salvează lecţia";
            _selectedTab = 1;
        }
        private void DocumentTestClick(object sender, EventArgs e)
        {
            menuSave.Text = "Salvează testul";
            _selectedTab = 3;
        }
        private void DocumentTablouDeBordClick(object sender, EventArgs e)
        {
            menuSave.Text = "";
            _selectedTab = 0;
        }
        private void DocumentProblemeClick(object sender, EventArgs e)
        {
            menuSave.Text = "Salvează problema";
            _selectedTab = 2;
        }

        #endregion

        private void btnAdaugaLectie_ToolTipTextNeeded(object sender, ToolTipTextNeededEventArgs e)
        {
            e.ToolTipText = "Adaugă lecţia la acelaşi nivel cu cea selectată sau la nivel inferior.";
        }

        private void btnLinkAdminTipuri_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            menuAdminTipuri.PerformClick();
        }
        #region Backup
        private void btnBackup_Click(object sender, EventArgs e)
        {
            MakeBackup();
        }

        private void btnRestoreBackup_Click(object sender, EventArgs e)
        {
            RestoreBackup();
        }

        #endregion
        #endregion

        #region Lectii
        private void treeViewLectii_Select(object sender, EventArgs e)
        {
            if (treeViewLectii.SelectedNode == null)
                return;

            ResourcesHandler.Instance.SelectedLectie = ((CustomTreeNode<Lectie>) treeViewLectii.SelectedNode).CustomStruct;
            SetLectieInformation();
        }
        private void btnCautaLectie_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Config.AppDataPath;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.Contains(Config.AppDataPath))
                    txtLocatieLectie.Text = openFileDialog.FileName;
                else
                    txtLocatieLectie.Text = Messages.INCORRECT_LECTIE_PATH;
            }
        }
        private void btnCautaProblemeAsociate_Click(object sender, EventArgs e)
        {
            ResourcesHandler.Instance.SelectedProblemeIds = txtProblemeAsociate.Text;
            if (new FrmSelectareProblema().ShowDialog() == DialogResult.OK)
            {
                txtProblemeAsociate.Text = ResourcesHandler.Instance.SelectedProblemeIds;
            }
        }
        private void btnCautaTesteAsociate_Click(object sender, EventArgs e)
        {
            ResourcesHandler.Instance.SelectedTesteIds = txtTesteAsociate.Text;
            if (new FrmSelectareTest().ShowDialog() == DialogResult.OK)
            {
                txtTesteAsociate.Text = ResourcesHandler.Instance.SelectedTesteIds;
            }
        }
        private void btnStergeLectie_Click(object sender, EventArgs e)
        {
            DeleteSelectedLectie();
        }
        private void btnLectieNoua_Click(object sender, EventArgs e)
        {
            SetNewLectie();
        }
        private void radMenuAddSameLectie_Click(object sender, EventArgs e)
        {
            AddLectie();
        }
        private void radMenuAddInferiorLectie_Click(object sender, EventArgs e)
        {
            AddInferiorLectie();
        }
        private void btnSaveModifLectie_Click(object sender, EventArgs e)
        {
            SaveChangesLectie();
        }

        private void MenuItemLectieNoua_Click(object sender, EventArgs e)
        {
            txtLocatieLectie.Text = txtProblemeAsociate.Text = txtTesteAsociate.Text
                = txtTitluLectie.Text = comboBoxDificultateLectie.Text = "";
        }
        private void MenuItemDeleteLectie_Click(object sender, EventArgs e)
        {
            DeleteSelectedLectie();
        }

        private void btnPrevizualizeaza_Click(object sender, EventArgs e)
        {
            string file_path = txtLocatieLectie.Text;
            if (string.IsNullOrEmpty(file_path))
                return;

            if (!File.Exists(file_path) &&
                 !File.Exists(file_path))
                return;

            new FrmNavigatorLectie(file_path).ShowDialog();
        }
        #endregion
        #region Probleme
        private void listaProbleme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaProbleme.SelectedItems.Count != 1)
                return;
            ResourcesHandler.Instance.SelectedProblema =
                ((CustomListViewItem<Problema>) listaProbleme.SelectedItems[0]).CustomStruct;
            SetProblemaInformation();
        }
        private void btnAdaugaProblema_Click(object sender, EventArgs e)
        {
            AddProblema();
        }
        private void btnStergeProblema_Click(object sender, EventArgs e)
        {
            DeleteSelectedProblema();
            SetNewProblema();
        }
        private void btnSaveModifProblema_Click(object sender, EventArgs e)
        {
            SaveChangesProblema();
        }
        private void btnProblemaNoua_Click(object sender, EventArgs e)
        {
            SetNewProblema();
        }

        private void btnAddUnitateTestare_Click(object sender, EventArgs e)
        {
            AddUnitateTestare();
        }

        private void btnModifyUnitateTestare_Click(object sender, EventArgs e)
        {
            ModifyUnitateTestare();
        }

        private void btnDeleteUnitateTestare_Click(object sender, EventArgs e)
        {
            DeleteUnitateTestare();
        }

        private void listaUnitatiTestare_DoubleClick(object sender, EventArgs e)
        {
            ModifyUnitateTestare();
        }
        #endregion
        #region Teste
        private void btnTestNou_Click(object sender, EventArgs e)
        {
            SetNewTest();
        }
        private void btnModifyIntrebare_Click(object sender, EventArgs e)
        {
            ModifyIntrebareTest();
        }
        private void btnDeleteIntrebare_Click(object sender, EventArgs e)
        {
            DeleteIntrebareTest();
        }   
        private void listaIntrebariTest_DoubleClick(object sender, EventArgs e)
        {
            if (listaIntrebariTest.SelectedItem == null)
                return;

            ModifyIntrebareTest();
        }
        private void btnAdaugaTest_Click(object sender, EventArgs e)
        {
            AddTest();
        }
        private void btnStergeTest_Click(object sender, EventArgs e)
        {
            DeleteSelectedTest();
        }
        private void btnSaveModifTest_Click(object sender, EventArgs e)
        {
            SaveChangesTest();
        }

        private void treeViewTeste_Selected(object sender, EventArgs e)
        {
            if (treeViewTeste.SelectedNode == null)
                return;
            CustomTreeNode<Test> selectedNode = (CustomTreeNode<Test>)treeViewTeste.SelectedNode;
            if (selectedNode.IsCustomParent)
            {
                SetNewTest();
                return;
            }

            ResourcesHandler.Instance.SelectedTest = selectedNode.CustomStruct;
            SetTestInformation();
        }

        private void radMenuIntrebareTest_Click(object sender, EventArgs e)
        {
            AddIntrebareTest("test");
        }

        private void radMenuIntrebareGrila_Click(object sender, EventArgs e)
        {
            AddIntrebareTest("grila");
        }
        #endregion

        #region Menu
        private void menuReload_Click(object sender, EventArgs e)
        {
            SetNewLectie();
            SetNewProblema();
            SetNewTest();
            ReloadInfo();
        }

        private void menuBackup_Click(object sender, EventArgs e)
        {
            MakeBackup();
        }

        private void menuRestoreBackup_Click(object sender, EventArgs e)
        {
            SetNewLectie();
            SetNewProblema();
            SetNewTest();
            RestoreBackup();
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            switch (_selectedTab)
            {
                case 0: //tablou de bord
                    break;

                case 1: //lectii
                    btnSaveModifLectie.PerformClick();
                    break;
                case 2: //probleme
                    btnSaveModifProblema.PerformClick();
                    break;
                case 3: //teste
                    btnSaveModifTest.PerformClick();
                    break;

                default:
                    break;
            }
        }

        private void menuSaveAll_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void menuAboutApplication_Click(object sender, EventArgs e)
        {
            new FrmAboutBox().ShowDialog();
        }

        private void menuCloseApplication_Click(object sender, EventArgs e)
        {
            //if (Messages.ShowMessageBox(Messages.CLOSE_APP_ARRAY[0], Messages.CLOSE_APP_ARRAY[1],
            //   "question") == DialogResult.Yes)
            Close();
        }

        private void menuAdminTipuri_Click(object sender, EventArgs e)
        {
            if (new FrmAdministrareTipuri().ShowDialog() == DialogResult.OK)
            {
                FillTipuriGroups(true);
            }
        }
        #endregion

        private void listaUnitatiTestare_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaUnitatiTestare.SelectedItem == null)
                return;
            btnModifyUnitateTestare.Enabled = true;
            btnDeleteUnitateTestare.Enabled = true;
        }

        private void btnViewCodSursaCPP_Click(object sender, EventArgs e)
        {
            ShowCodSursaWindow(ref ResourcesHandler.Instance.SelectedCPPSource, lblCodSursaCPP, "C++.NET");
        }

        private void listaIntrebariTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaIntrebariTest.SelectedItem == null)
                return;
            btnModifyIntrebare.Enabled = true;
            btnDeleteIntrebare.Enabled = true;
        }

    }
}