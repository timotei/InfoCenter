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
#define debug
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ICSharpCode.TextEditor;
using InfoCenter.Classes;
using InfoCenter.Controls;
using InfoCenter.Forms;
using InfoCenter.Handlers;
using InfoCenter.Util;
using Telerik.WinControls.UI;
using Res = InfoCenter.Handlers.ResourcesHandler;

namespace InfoCenter
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Procesul aplicatiei de modificare aplicatia
        /// </summary>
        private Process _continutProces;

        public MainForm()
        {
            CheckForIllegalCrossThreadCalls = false;

            Splasher.Status = Messages.LODING_APP;
            Thread loadingThread = new Thread(LoadingThread)
            {
                IsBackground = true,
                Name = "loading"
            };
            loadingThread.Start();

            InitializeComponent();
            EventsHandler.Instance.AddEvent("InitializeComponents finish", true);

            // daca nu s-a terminat incarcarea astept dupa ea
            loadingThread.Join();

            SetInformation();
            Splasher.Close();

            // events
            navigatorLectii.DocumentCompleted += navigatorLectii_DocumentCompleted;

            txtCodSursa.SourceTextBox.TextChanged += SourceTextBoxTextChanged;
            txtCodSursa.SourceTextBox.ActiveTextAreaControl.TextArea.KeyDown += SourceTextBoxKeyDown;
            
            txtCodSursa.SourceTextBox.SetHighlighting("C++.NET");
            txtSursaProblema.SourceTextBox.SetHighlighting("C++.NET");
            txtSursaProblema.SourceTextBox.ActiveTextAreaControl.TextArea.Document.ReadOnly = true;
            splitContainerCuvinteCheie.Panel2Collapsed = true;

            CompilerHandler.Instance.FilesInOutChecker.Tick += CheckFilesInOutTick;
            CompilerHandler.Instance.FilesInOutChecker.Interval = 2000;
            CompilerHandler.Instance.FilesInOutChecker.Start();
        }

        void navigatorLectii_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            lblStartLectie.Visible = false;
        }

        #region MainForm
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Instance.SaveSettings();
            Res.Instance.UpdateContinutAccesat(ribbonBar.StartMenuRightColumnItems);
            Res.Instance.UpdateFragmenteDeCod();
            Logging.Instance.CloseLog();
            DatabaseHandler.Instance.CloseDBAcess();
        }
        #endregion
        #region ribbonBar Methods
        private void ribbonTabStartPage_Click(object sender, EventArgs e)
        {
            SelectTab(tabPageStart.Name);
        }
        private void ribbonTabLectii_Click(object sender, EventArgs e)
        {
            SelectTab(tabPageLectii.Name);
        }
        private void ribbonTabProbleme_Click(object sender, EventArgs e)
        {
            SelectTab(tabPageProbleme.Name);
        }
        private void ribbonTabTeste_Click(object sender, EventArgs e)
        {
            SelectTab(tabPageTeste.Name);
        }
        private void ribbonTabCompilator_Click(object sender, EventArgs e)
        {
            SelectTab(tabPageCompilator.Name);
        }

        #region Lectii
        private void btnProblemeLectie_Click(object sender, EventArgs e)
        {
            listaProbleme.Items.Clear();
            if (Res.Instance.SelectedLectie.IdsProbleme == null)
                return;

            foreach (string id in Res.Instance.SelectedLectie.IdsProbleme.Split(','))
            {
                int pId;
                int.TryParse(id, out pId);
                if (pId == 0)
                    continue;

                Problema problema = Res.Instance.GetProblemaById(pId);
                listaProbleme.Items.Add(new CustomListViewItem<Problema>(problema.Titlu
                    , problema, listaProbleme.Groups[problema.Tip]));
            }

            SelectTab(tabPageProbleme.Name);
            tabControlSubProbleme.SelectTab(tabPageListaProbleme);
        }

        private void btnTesteLectie_Click(object sender, EventArgs e)
        {
            CustomTreeNode<Test>[] list =
                (from CustomTreeNode<Test> test in listaTeste.Nodes
                 where test.Text.Equals("Teste asociate lectiei")
                 select test).ToArray();

            if (list.Length > 0)
                listaTeste.Nodes.Remove(list[0]);

            if (Res.Instance.SelectedLectie.IdsTeste == null)
                return;

            var treeNode = new CustomTreeNode<Test>("Teste asociate lectiei",
                Res.Instance.GetTesteTreeNodes(Res.Instance.SelectedLectie.IdsTeste),
                null, true);
            treeNode.Expand();
            treeNode.BackColor = Color.YellowGreen;
            listaTeste.Nodes.Add(treeNode);

            SelectTab(tabPageTeste.Name);
        }

        #endregion
        #region Probleme

        private void comboCautaProblema_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) //ENTER
            {
                btnCautaProbleme.PerformClick();
            }
        }
        private void comboCautaCuvantCheie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) //ENTER
            {
                btnCautaCuvantCheie.PerformClick();
            }
        }

        private void btnCautaProbleme_Click(object sender, EventArgs e)
        {
            tabPageListaProbleme.Text = "Rezultate căutare probleme";

            AddSearchedBeforeItems(comboCautaProblema);
            string text = comboCautaProblema.Text;
            FillProbleme(text, false);
        }
        private void btnCautaCuvantCheie_Click(object sender, EventArgs e)
        {
            AddSearchedBeforeItems(comboCautaCuvantCheie);
            FillCuvinteCheie(comboCautaCuvantCheie.Text, false);
        }

        private void btnToateCuvinteleCheie_Click(object sender, EventArgs e)
        {
            FillCuvinteCheie("", false);
        }
        private void btnToateProblemele_Click(object sender, EventArgs e)
        {
            FillProbleme("", false);
        }
        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (Res.Instance.SelectedProblema == null)
            {
                Messages.ShowMessageBox(Messages.NO_PROBLEMA_SELECTED_ARRAY[0],
                    Messages.NO_PROBLEMA_SELECTED_ARRAY[1], "warn");
                return;
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                const string extension = ".cpp";
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName + extension, false))
                    {
                        sw.WriteLine("Cerinţă: " + txtCerintaProblema.Text);
                        sw.Write("\r\n Rezolvare:" + txtSursaProblema.Text);
                        sw.Flush();
                    }
                    Messages.ShowMessageBox(Messages.FILE_SAVED, "info");
                }
                catch (Exception ex)
                {
                    ExceptionsHandler.Instance.AddException(ex, Messages.ERROR_SAVE_FILE);
                }
            }
        }
        private void btnSalvareRapida_Click(object sender, EventArgs e)
        {
            if (Res.Instance.SelectedProblema == null)
            {
                Messages.ShowMessageBox(Messages.NO_PROBLEMA_SELECTED_ARRAY[0],
                    Messages.NO_PROBLEMA_SELECTED_ARRAY[1], "warn");
                return;
            }
            if (!Settings.Instance.HasSetting(Settings.QuickSavePath))
            {
                Messages.ShowMessageBox(Messages.QUICK_SAVE_FOLDER_NOT_DEFINED, "warn");
                return;
            }

            try
            {
                const string extension = ".cpp";
                using (StreamWriter sw = new StreamWriter(
                    Settings.Instance.GetSetting(Settings.QuickSavePath) + "\\"
                    + Res.Instance.SelectedProblema.Id + extension))
                {
                    sw.WriteLine("Cerinta: " + txtCerintaProblema.Text);
                    sw.Write("\r\n Rezolvare:" + txtSursaProblema.Text);
                    sw.Flush();
                }
            }
            catch (Exception ex)
            {
                ExceptionsHandler.Instance.AddException(ex, Messages.ERROR_SAVE_FILE);
            }
        }

        private void btnMaresteSursa_Click(object sender, EventArgs e)
        {
            FrmAfisareMarita window = new FrmAfisareMarita("Cod sursă problemă", "C++.NET");
            window.SetText(txtSursaProblema.Text);
            window.ShowDialog();
        }
        private void btnMaresteCerinta_Click(object sender, EventArgs e)
        {
            FrmAfisareMarita window = new FrmAfisareMarita("Cerinţă problemă", "");
            window.SetText(txtCerintaProblema.Text);
            window.ShowDialog();
        }

        private void btnRezolvaProblema_Click(object sender, EventArgs e)
        {
            if (txtCodSursa.Text.Length > 0)
            {
                if (Messages.ShowMessageBox(Messages.EXISTING_SOURCE_CODE_ARRAY[0],
                    Messages.EXISTING_SOURCE_CODE_ARRAY[1],"question")!= DialogResult.Yes)
                {
                    return;
                }
            }

            SelectTab(tabPageCompilator.Name);
            txtCodSursa.Text = txtSursaProblema.Text;

            //writeDateIntrare();
            //Compile();
        }
        #endregion
        #region Teste
        private void btnIncepeTest_Click(object sender, EventArgs e)
        {
            if (Res.Instance.SelectedTest == null)
            {
                Messages.ShowMessageBox(Messages.NO_TEST_SELECTED_ARRAY[0],
                    Messages.NO_TEST_SELECTED_ARRAY[1], "warn");
                return;
            }

            if (testTimer.IsStarted)
                return;

            StartTest();
        }
        private void btnResetTest_Click(object sender, EventArgs e)
        {
            if (Res.Instance.SelectedTest == null)
            {
                Messages.ShowMessageBox(Messages.NO_TEST_SELECTED_ARRAY[0],
                    Messages.NO_TEST_SELECTED_ARRAY[1], "warn");
                return;
            }

            if (!testTimer.IsStarted)
                return;

            StartTest();
        }
        private void btnCorecteazaTest_Click(object sender, EventArgs e)
        {
            if (Res.Instance.SelectedTest == null)
            {
                Messages.ShowMessageBox(Messages.NO_TEST_SELECTED_ARRAY[0],
                    Messages.NO_TEST_SELECTED_ARRAY[1], "warn");
                return;
            }

            if (!testTimer.IsStarted)
                return;

            StopTest(true);
        }
        #endregion
        #region Compilator
        private void comboFontSize2_TextChanged(object sender, EventArgs e)
        {
            txtCodSursa.Font = FontUtil.GetFont(comboFont2.Text, comboFontSize2.Text);
        }
        private void comboFont2_TextChanged(object sender, EventArgs e)
        {
            txtCodSursa.Font = FontUtil.GetFont(comboFont2.Text, comboFontSize2.Text);
        }
        private void btnFontIncrease2_Click(object sender, EventArgs e)
        {
            txtCodSursa.Font = FontUtil.GetFont(txtCodSursa.Font, 1);
            comboFontSize2.Text = ((int)txtCodSursa.Font.Size).ToString();
        }
        private void btnFontDecrease2_Click(object sender, EventArgs e)
        {
            txtCodSursa.Font = FontUtil.GetFont(txtCodSursa.Font, -1);
            comboFontSize2.Text = ((int)txtCodSursa.Font.Size).ToString();
        }

        #endregion

        #region Ribbon Menu

        private void radMenuIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void radMenuOptiuni_Click(object sender, EventArgs e)
        {
            new FrmOptiuni().ShowDialog();
        }

        #endregion
        #endregion
        #region Form
        #region Testare
        private void gridVerificare_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1 ||
                e.RowIndex >= gridVerificare.Rows.Count ||
                e.ColumnIndex >= gridVerificare.Rows[e.RowIndex].Cells.Count)
                return;
            UnitateTestare unitate = (gridVerificare.Rows[e.RowIndex].Cells[0].Value as UnitateTestare);
            if (unitate == null)
                return;
            new FrmDetaliiUnitateTestare(unitate).ShowDialog();
        }

        private void gridVerificare_CommandCellClick(object sender, EventArgs e)
        {
            if (sender == null || !(sender is GridCommandCellElement))
                return;

            int rowIndex = (sender as GridCommandCellElement).RowIndex;
            if (rowIndex > 0 && rowIndex >= gridVerificare.Rows.Count)
                return;
            UnitateTestare unitate = gridVerificare.Rows[rowIndex].Cells[0].Value as UnitateTestare;

            if (unitate == null)
                return;
            VerificaDateIesire(unitate, rowIndex);
        }

        private void gridVerificare_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement.ColumnInfo is GridViewCommandColumn)
            {
                ((RadButtonElement)e.CellElement.Children[0]).Image = Properties.Resources.imgPlay16;
                ((RadButtonElement)e.CellElement.Children[0]).ImageAlignment = ContentAlignment.MiddleCenter;
            }
        }

        #endregion
        #region FirstPage
        private void lblLinkLectii_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectTab(tabPageLectii.Name);
        }

        private void lblLinkProbleme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectTab(tabPageProbleme.Name);
        }

        private void lblLinkTest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectTab(tabPageTeste.Name);
        }


        private void lblLinkCompilator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectTab(tabPageCompilator.Name);
        }

        private void lblAutentificareProfesor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                _continutProces = new Process
                                      {
                                          StartInfo =
                                              {
                                                  FileName =
                                                      Path.Combine(Application.StartupPath, "InfoCenter Continut.exe")
                                              }
                                      };
                _continutProces.Exited += ProcesExited;
                _continutProces.Start();
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                Messages.ShowMessageBox(Messages.FILE_NOT_FOUND_REQUIRED, "error");
                ExceptionsHandler.Instance.AddException(ex, "");
            }
        }

        void ProcesExited(object sender, EventArgs e)
        {
            SetStatusLabelState(Messages.LOADING_UPDATE_CONTINUT, 0);
            LoadingThread();
            SetInformation();
            SetStatusLabelState(Messages.LOADING_FINISHED, 0);
        }
        #endregion

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in tabPageSubiectTest.Controls)
                if (control.GetType().Equals(typeof(FrmIntrebareGrilaGroupBox)))
                {
                    control.MaximumSize = new Size(tabPageSubiectTest.Width - 20, 600);
                }
        }
        private void cuprinsLectii_Selected(object sender, EventArgs e)
        {
            if (cuprinsLectii.SelectedNode == null)
                return;
            var treeNode = cuprinsLectii.SelectedNode as CustomTreeNode<Lectie>;
            if (treeNode == null)
                return;

            Lectie lectie = treeNode.CustomStruct;
            if (lectie == null)
                return;

            lblStartLectie.Visible = false;

            if (lectie.IsBrowsable)
            {
                lblStartLectie.Text = Messages.LOADING_LECTIE;
                lblStartLectie.Visible = true;
                Res.Instance.SelectedLectie = lectie;
                SetLectieInformation();
                navigatorLectii.Navigate(Config.AppDataPath + lectie.LocatieLectie);
                if (!File.Exists(Config.AppDataPath + lectie.LocatieLectie))
                {
                    SetStatusLabelState(Messages.LECTIE_FILE_NOT_FOUND, -1);
                }
                else
                {
                    SetStatusLabelState(Messages.LECTIE_FILE_LOADED, 0);
                }
            }
        }
        private void listaProbleme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaProbleme.SelectedItems.Count == 0)
                return;
            SelectProblema(listaProbleme.SelectedItems[0]);
        }
        private void listaRezultateCautareProbleme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaRezultateCautareProbleme.SelectedItems.Count == 0)
                return;
            SelectProblema(listaRezultateCautareProbleme.SelectedItems[0]);
        }

        private void listaTeste_Selected(object sender, EventArgs e)
        {
            if (listaTeste.SelectedNode == null)
                return;
            var item = listaTeste.SelectedNode as CustomTreeNode<Test>;
            if (item == null)
                return;

            Res.Instance.SelectedTest = item.CustomStruct;

            lblTimpScurs.Text = "Timp scurs: - ";
            lblPunctaj.Text = "Punctaj: - ";

            if (!item.IsCustomParent)
            {
                ShowTestWelcome(true);
                ShowTestFinish(false);
            }
        }

        private void testTimer_Tick(object sender, EventArgs e)
        {
            lblTimpScurs.Text = string.Format("Timp scurs: {0}", testTimer);
        }
        private void toolStripStatus_Click(object sender, EventArgs e)
        {
            EventsHandler.Instance.EventsForm = new FrmEventsWindow();
            EventsHandler.Instance.ShowEventsWindow();
        }
        private void toolStripLabelCopyright_Click(object sender, EventArgs e)
        {
            new FrmAboutBox().ShowDialog();
        }

        private void btnTestareProgram_Click(object sender, EventArgs e)
        {
            tabControlSubCompilator.SelectTab(tabPageTestareProgram);
            btnExecuta.PerformClick();
        }
        private void btnTestareAutomaticaProgram_Click(object sender, EventArgs e)
        {
            tabControlSubCompilator.SelectTab(tabPageTestareAutomata);
        }
        private void SourceTextBoxTextChanged(object sender, EventArgs e)
        {
            _sourceTextModified = true;
        }

        private void SourceTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.Enter)) // CompileText
            {
                btnExecuta.PerformClick();
            }
            else
                if (e.KeyData == (Keys.Control | Keys.S)) //save
                {
                    btnSaveCodSursa_Click(null, null);
                }
        }


        private void btnExecuta_Click(object sender, EventArgs e)
        {
            ExecuteCompiledFile();
        }
        private void txtRezultatCompilare_Click(object sender, EventArgs e)
        {
            if (!sender.GetType().Equals(typeof(RichTextBox)) ||
                !e.GetType().Equals(typeof(MouseEventArgs)))
                return;

            RichTextBox textbox = (sender as RichTextBox);
            MouseEventArgs ev = (e as MouseEventArgs);
            if (textbox == null)
                return;
            if (ev == null)
                return;

            int charIndex = textbox.GetCharIndexFromPosition(new Point(ev.X, ev.Y));
            if (charIndex < 0)
                return;
            // textbox rezultat compilare
            int lineNumber = textbox.GetLineFromCharIndex(charIndex);
            char charToSplit = Res.Instance.SelectedCompilerType == CompilerType.CPP ? ':' : ',';

            if (lineNumber >= txtRezultatCompilare.Lines.Length)
                return;

            string[] content = txtRezultatCompilare.Lines[lineNumber].Split(charToSplit);
            if (content.Length < 3)
                return;

            // text box cod sursa
            int line;
            int.TryParse(content[0], out line);
            int col;
            int.TryParse(content[1], out col);

            TextEditorControl textBox = txtCodSursa.SourceTextBox;
            line--;
            if (line >= textBox.Document.TotalNumberOfLines)
                line = textBox.Document.TotalNumberOfLines - 1;
            if (line == -1)
                return;

            TextAreaControl textArea = textBox.ActiveTextAreaControl;
            textArea.ScrollTo(line, col);
            textArea.Caret.Position = new TextLocation(col, line);
            textArea.Caret.UpdateCaretPosition();
            textArea.SelectionManager.SetSelection(
                new TextLocation(col, line),  //start
                new TextLocation(textBox.Document.LineSegmentCollection[line].Length, line)); //end
        }
        private void radMenuSelectate_Click(object sender, EventArgs e)
        {
            VerificaTeste(true);
        }

        private void radMenuToate_Click(object sender, EventArgs e)
        {
            VerificaTeste(false);
        }

        private void btnAdaugaTestare_Click(object sender, EventArgs e)
        {
            var window = new FrmDetaliiUnitateTestare(null);
            if (window.ShowDialog() == DialogResult.OK && window.UnitateTestare != null)
            {
                gridVerificare.Rows.Add(window.UnitateTestare, "", "", "");
                gridVerificare.Visible = true;
            }
        }

        private void btnSaveCodSursa_Click(object sender, EventArgs e)
        {

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    const string extension = ".cpp";
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName + extension))
                    {
                        sw.WriteLine("Salvat de Info Center");
                        sw.Write(txtCodSursa.Text);
                        sw.Flush();
                    }
                }
                catch (Exception ex)
                {
                    ExceptionsHandler.Instance.AddException(ex, Messages.ERROR_SAVE_FILE);
                }
            }
        }

        private void listaCuvinteCheie_Selected(object sender, EventArgs e)
        {
            if (listaCuvinteCheie.SelectedNode == null)
                return;
            var treeNode = listaCuvinteCheie.SelectedNode as CustomTreeNode<CuvantCheie>;

            if (treeNode == null || treeNode.IsCustomParent)
                return;

            if (splitContainerCuvinteCheie.Panel2Collapsed)
                splitContainerCuvinteCheie.Panel2Collapsed = false;

            listaRezultateCautareProbleme.Items.Clear();
            foreach (Problema problema in treeNode.ListaProbleme)
            {
                var item = new CustomListViewItem<Problema>(problema.Titlu, problema) { Group = listaProbleme.Groups[problema.Tip] };
                listaRezultateCautareProbleme.Items.Add(item);
            }
        }

        private void btnIntrebareUrmatoare_Click(object sender, EventArgs e)
        {
            ShowNextIntrebare();
        }

        private void btnIntrebareInainte_Click(object sender, EventArgs e)
        {
            ShowPreviousIntrebare();
        }

        #endregion

        private void radMenuReloadInfo_Click(object sender, EventArgs e)
        {
            SetStatusLabelState(Messages.LOADING_UPDATE_CONTINUT, 0);
            LoadingThread();
            SetInformation();
            SetStatusLabelState(Messages.LOADING_FINISHED, 0);
        }

        private void btnFragmenteDeCod_Click(object sender, EventArgs e)
        {
            FrmFragmenteDeCod window = new FrmFragmenteDeCod();
            if (window.ShowDialog() == DialogResult.Yes)
            {
                if (window.FragmentDeCod == null)
                    return;

                txtCodSursa.Text = txtCodSursa.Text.Insert(txtCodSursa.SourceTextBox.ActiveTextAreaControl.Caret.Offset,
                    window.FragmentDeCod.CodSursa);
            }
        }

        private void radMenuUpdateApplication_Click(object sender, EventArgs e)
        {
            Thread updateThread = new Thread(UpdateThread) { Name = "update", IsBackground = true };
            updateThread.Start();            
        }
        private void UpdateThread()
        {
            Invoke(new MethodInvoker(() => SetStatusLabelState(Messages.UPDATING_SEARCH, 0)));
            if (UpdatesManager.CheckForUpdates())
            {
                Invoke(new MethodInvoker( () => SetStatusLabelState(Messages.UPDATING_STARTED,0)));
                if (!UpdatesManager.DoUpdate())
                {
                    Messages.ShowMessageBox(Messages.ERROR_UPDATING);
                    Invoke(new MethodInvoker(() => SetStatusLabelState(Messages.UPDATING_FINISHED_ERROR, 1)));
                }
                else
                {
                    radMenuReloadInfo.PerformClick();
                    Invoke(new MethodInvoker(() => SetStatusLabelState(Messages.UPDATING_FINISHED_OK, 0)));
                }
            }
            else
            {
                Messages.ShowMessageBox(Messages.NO_UPDATE_NEEDED);
                Invoke(new MethodInvoker(() => SetStatusLabelState("", 4)));
            }
        }

        private void lblLinkProgramNou_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtCodSursa.Text = "";
        }
    }
}