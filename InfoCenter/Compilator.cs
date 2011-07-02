// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using InfoCenter.Classes;
using InfoCenter.Handlers;
using InfoCenter.Util;
using Res = InfoCenter.Handlers.ResourcesHandler;
using System.Collections.Generic;

namespace InfoCenter
{
    partial class MainForm
    {
        /// <summary>
        /// Executa ultimul fisierul compilat daca nu a fost modificata sursa, altfel il compileaza inainte
        /// </summary>
        private bool SetupExecuteCompiledFile()
        {
            if (_sourceTextModified)
                Compile();

            if (!WriteDateIntrare())
            {
                Messages.ShowMessageBox(Messages.ERROR_WRITING_DATE_INTRARE, "error");
                return false;
            }

            if (txtCodSursa.HasConsoleIn() && txtDateIntrareProgram.Text.Length == 0)
            {
                Messages.ShowMessageBox(Messages.NO_INPUT_PROVIDED, "error");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Executa fisierul compilat intr-un thread nou
        /// </summary>
        private void ExecuteCompiledFile()
        {
            if (!SetupExecuteCompiledFile())
                return;

            CompilerHandler.Instance.ExecuteCompiledFileThread = new Thread(ExecuteCompiledFileThread)
            {
                Name = "executeThread",
                IsBackground = true
            };

            Invoke(new SetStatusLabel(SetStatusLabelState), Messages.WAITING_FOR_EXECUTE_EXIT, 2);
            CompilerHandler.Instance.ExecuteCompiledFileThread.Start();
            CompilerHandler.Instance.ExecuteCompiledFileThread.Join();
        }
        /// <summary>
        /// Thread-ul pentru executarea fisierului compilat
        /// </summary>
        private void ExecuteCompiledFileThread()
        {
            CompilerHandler.Instance.ExecuteCompiledFile(CompilerHandler.Instance.GetCompilerByType(Res.Instance.SelectedCompilerType));

            ShowOutput();
            SetStatusLabelState("Ok", 2);

            _sourceTextModified = false;
        }
        /// <summary>
        /// Compileaza textul existent in Compilator
        /// </summary>
        private void Compile()
        {
            if (!UpdateCompilerData())
                return;

            if (CompilerHandler.Instance.CompilerThread != null)
            {
                Messages.ShowMessageBox(Messages.COMPILE_STARTED, "info");
                return;
            }

            CompilerHandler.Instance.CompilerThread = new Thread(CompileThread)
            {
                Name = "compiler",
                IsBackground = true
            };
            CompilerHandler.Instance.CompilerThread.Start();
            CompilerHandler.Instance.CompilerThread.Join(2000);
        }

        /// <summary>
        /// Actualizeaza informatile despre compilator
        /// </summary>
        /// <returns></returns>
        private bool UpdateCompilerData()
        {
            CompilerHandler.Instance.CPPCompiler.FullPath = Settings.Instance.GetSetting(Settings.CPPPath).Valoare;
            CompilerHandler.Instance.CPPCompiler.ArgumentsPattern = Settings.Instance.GetSetting(Settings.CPPPattern).Valoare;

            if (Settings.Instance.GetSetting(Settings.CPPPath).Valoare == "" &&
                !File.Exists(Settings.Instance.GetSetting(Settings.CPPPath).Valoare))
            {
                Messages.ShowMessageBox(Messages.COMPILER_DEFINED_NOT_VALID);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Thread-ul pentru compilare
        /// </summary>
        private void CompileThread()
        {
            BeginInvoke(new SetStatusLabel(SetStatusLabelState), Messages.COMPILING_STARTED, 2);

            if (CompilerHandler.Instance.CompileText(txtCodSursa.Text, Res.Instance.SelectedCompilerType))
            {
                if (CompilerHandler.Instance.LastError.Contains("error") || CompilerHandler.Instance.LastError.Contains("Error"))
                    BeginInvoke(new SetStatusLabel(SetStatusLabelState), Messages.COMPILING_FINISHED_WARN, -1);
                else
                    BeginInvoke(new SetStatusLabel(SetStatusLabelState), Messages.COMPILING_FINISHED_OK, 0);                
            }
            else
            {
                BeginInvoke(new SetStatusLabel(SetStatusLabelState), Messages.COMPILING_FINISHED_ERROR, 1);
            }
            CompilerHandler.Instance.CompilerThread = null;
            BeginInvoke(new MethodInvoker(ShowOutput));
        }

        /// <summary>
        /// Verifica datele de iesire daca corespund cu cele corecte
        /// <param name="unitate">Unitatea de testare</param>
        /// <param name="rowIndex">Indexul liniei unitatii testare</param>
        /// </summary>
        private void VerificaDateIesire(UnitateTestare unitate, int rowIndex)
        {
            if (unitate == null)
                return;

            txtDateIntrareProgram.Text = unitate.DateIntrare;
            ExecuteCompiledFile();

            // si pentru mai multe fisiere?
            string rezultat = txtRezultatProgram.Text; // cout
            unitate.DateUtilizator = rezultat;
            bool ok = unitate.CheckOutput(rezultat);

            Image imgRezultat = Properties.Resources.imgWrong16;
            if (ok)
                imgRezultat = Properties.Resources.imgOk16;

            gridVerificare.Rows[rowIndex].Cells[3].Value = imgRezultat;
        }

        /// <summary>
        /// Afiseaza output-ul ultimului program rulat.
        /// </summary>
        private void ShowOutput()
        {
            if (CompilerHandler.Instance.LastError.Length == 0 ||
                CompilerHandler.Instance.LastError.Contains("Microsoft")) // bug on MS's C++ compiler.
            {
                txtRezultatCompilare.Text = CompilerHandler.Instance.LastOutput;
                //if (_selectTab)
                //    tabControlSubCompilator.SelectTab(1);
            }
            else
            {
                txtRezultatCompilare.Text = CompilerHandler.Instance.LastError;
                //tabControlSubCompilator.SelectTab(0);
            }

            foreach (string fileName in txtCodSursa.GetDateIesireFiles())
            {
                if (tabControlDateIesire.TabPages[fileName] == null)
                    continue;

                bool fileIn = fileName.EndsWith("in"); // daca fisierul este pentru citire
                // inserez punct pentru a delimita numele fisierului de extensie
                string newFileName = fileName.Insert(fileName.LastIndexOf(fileIn ? "in" : "out"), ".");
                ShowOutputForFile(newFileName, tabControlDateIesire.TabPages[fileName].Controls[0] as TextBox);
            }

            txtRezultatProgram.Text = CompilerHandler.Instance.ConsoleOutputText;
            FormatCompilerOutput();
        }

        /// <summary>
        /// Afiseaza output-ul din fisierul specificat in textBox
        /// </summary>
        /// <param name="fileName">Fisierul din care se ia output-ul</param>
        /// <param name="textBox">Textboxul in care se scrie informatia</param>
        private void ShowOutputForFile(string fileName, TextBox textBox)
        {
            string filePath = CompilerHandler.Instance.GetCompilerByType(Res.Instance.SelectedCompilerType).WorkingPath;
            if (!File.Exists(filePath + fileName) || textBox == null)
                return;

            try
            {
                using (StreamReader sr = new StreamReader(filePath + fileName))
                {
                    textBox.Text = sr.ReadToEnd();
                }
            }
            catch (DirectoryNotFoundException e)
            {
                EventsHandler.Instance.AddEvent(e.Message, true);
                ExceptionsHandler.Instance.AddException(e, "");
            }
            catch (FileNotFoundException e)
            {
                EventsHandler.Instance.AddEvent(e.Message, true);
                ExceptionsHandler.Instance.AddException(e, "");
            }
        }

        /// <summary>
        /// Formateaza output-ul de la compilator
        /// </summary>
        private void FormatCompilerOutput()
        {
            if (txtRezultatCompilare.Text.Length == 0)
            {
                txtRezultatCompilare.Text = "OK";
                return;
            }

            StringBuilder result = new StringBuilder();
            foreach (string str in txtRezultatCompilare.Lines)
            {
                // template: fileName.cpp:line:column error/warning: <error>
                if (Res.Instance.SelectedCompilerType == CompilerType.CPP)
                {
                    if ((str.Contains("error") || str.Contains("warning")) && str.Contains(":"))
                        result.Append(str.Substring(str.IndexOf(":") + 1));
                    else
                        result.Append(str);
                }

                result.AppendLine();
            }
            result.Replace("error", "Eroare");
            result.Replace("warning", "Atenţie");

            txtRezultatCompilare.Text = result.ToString();
            txtRezultatProgram.Text = CompilerHandler.Instance.ConsoleOutputText;
        }

        /// <summary>
        /// Returneaza datele de intrare pentru fisierul specificat (de pe forma)
        /// </summary>
        /// <param name="fileName">Numele fisierului</param>
        /// <returns></returns>
        private string GetDateIntrareByName(string fileName)
        {
            if (tabControlDateIntrare.TabPages[fileName] == null)
                return "";
            return tabControlDateIntrare.TabPages[fileName].Controls[0].Text;
        }

        /// <summary>
        /// Sterge rezultatele anterioare
        /// </summary>
        private void ClearDateIesire()
        {
            foreach (TabPage page in tabControlDateIesire.TabPages)
            {
                if (page.Controls.Count > 0)
                    page.Controls[0].Text = string.Empty;
            }
        }

        /// <summary>
        /// Scrie datele de intrare pentru toate fisierele declarate in codul sursa si pentru console in
        /// </summary>
        private bool WriteDateIntrare()
        {
            ClearDateIesire();

            // date de intrare in fisier
            var filesIn = txtCodSursa.GetDateIntrareFiles();
            foreach (string file in filesIn)
            {
                bool fileIn = file.EndsWith("in"); // daca fisierul este pentru citire
                // inserez punct pentru a delimita numele fisierului de extensie
                string fileName = file.Insert(file.LastIndexOf(fileIn ? "in" : "out"), ".");

                WriteDateIntrare(fileName, GetDateIntrareByName(file));
            }

            // date de intrare in consola
            if (txtCodSursa.HasConsoleIn())
            {
                //if (txtDateIntrareProgram.Text.Trim().Length == 0)
                //    if (Messages.ShowMessageBox(Messages.NO_CONSOLE_IN_TEXT_ARRAY[0],
                //        Messages.NO_CONSOLE_IN_TEXT_ARRAY[1],"question") == DialogResult.No)
                //        return false;

                CompilerHandler.Instance.ConsoleInputText = txtDateIntrareProgram.Text;
            }

            return true;
        }

        /// <summary>
        /// Scrie datele de intrare specificate in fisierul specificat
        /// <param name="fileName">Numele fisierului</param>
        /// <param name="dateIntrare">Datele de intrare</param>
        /// </summary>
        private void WriteDateIntrare(string fileName, string dateIntrare)
        {
            try
            {
                CompilerData compiler = CompilerHandler.Instance.GetCompilerByType(Res.Instance.SelectedCompilerType);
                string dateIntrareFilePath = compiler.WorkingPath + fileName;

                using (StreamWriter sw = new StreamWriter(dateIntrareFilePath, false, Encoding.ASCII))
                {
                    sw.Write(dateIntrare);
                    sw.Flush();
                }
            }
            catch (Exception ex)
            {
                ExceptionsHandler.Instance.AddException(ex, Messages.ERROR_SET_DATE_INTRARE);
                return;
            }
        }

        private void CheckFilesInOutTick(object sender, EventArgs e)
        {
            if (!_sourceTextModified)
                return;

            DeleteFilesInOutTabs();
            AddFilesInOutTabs();
        }

        /// <summary>
        /// Sterge taburile cu informatii legate de fisierele de intrare sau iesire, ne-necesare
        /// </summary>
        private void DeleteFilesInOutTabs()
        {
            var filesIn = txtCodSursa.GetDateIntrareFiles();
            var filesOut = txtCodSursa.GetDateIesireFiles();

            List<TabPage> tabPagesIn = (from TabPage page in tabControlDateIntrare.TabPages
                                        where !page.Name.Equals("tabcin")
                                        select page).ToList();
            List<TabPage> tabPagesOut = (from TabPage page in tabControlDateIesire.TabPages
                                         where !page.Name.Equals("tabcout")
                                         select page).ToList();

            var tabPagesToDelete = new List<TabPage>();

            tabPagesToDelete.AddRange(from TabPage page in tabPagesIn
                                      // nu gaseste numele pagini in lista filesIn
                                      where filesIn.Find(pg => pg == page.Name) == null
                                      select page);
            DeleteTabPages(ref tabPagesToDelete, tabControlDateIntrare);

            tabPagesToDelete.AddRange(from TabPage page in tabPagesOut
                                      // nu gaseste numele pagini in lista filesOut
                                      where filesOut.Find(pg => pg == page.Name) == null
                                      select page);
            DeleteTabPages(ref tabPagesToDelete, tabControlDateIesire);
        }

        /// <summary>
        /// Sterge paginile de tip TabPage specificate in lista din controlul specificat
        /// </summary>
        /// <param name="pagesToDelete">Paginile care trebuie sterse</param>
        /// <param name="control">Controlul din care trebuie sterse paginile</param>
        private void DeleteTabPages(ref List<TabPage> pagesToDelete, TabControl control)
        {
            foreach (var page in pagesToDelete)
            {
                control.TabPages.Remove(page);
            }
            pagesToDelete.Clear();
        }

        /// <summary>
        /// Adauga taburi pentru a insera sau afisa informatii legate de fisierele de intrare sau iesire
        /// </summary>
        private void AddFilesInOutTabs()
        {
            var filesIn = txtCodSursa.GetDateIntrareFiles();
            var filesOut = txtCodSursa.GetDateIesireFiles();

            foreach (var file in filesIn)
            {
                if (tabControlDateIntrare.TabPages[file] != null)
                    continue;

                if (CreateTabPage(file) != null)
                    tabControlDateIntrare.TabPages.Add(CreateTabPage(file));
            }

            foreach (var file in filesOut)
            {
                if (tabControlDateIesire.TabPages[file] != null)
                    continue;

                if (CreateTabPage(file) != null)
                    tabControlDateIesire.TabPages.Add(CreateTabPage(file));
            }
        }

        /// <summary>
        /// Creeaza un tab page care contine un textBox pentru a fi adaugat pentru fisiere in&out.
        /// </summary>
        /// <param name="fileName">Numele fisierului</param>
        /// <returns></returns>
        private TabPage CreateTabPage(string fileName)
        {
            if (!fileName.EndsWith("out") && !fileName.EndsWith("in"))
                return null;

            bool fileIn = fileName.EndsWith("in"); // daca fisierul este pentru citire
            // inserez punct pentru a delimita numele fisierului de extensie
            string tabText = fileName.Insert(fileName.LastIndexOf(fileIn ? "in" : "out"), ".");

            TabPage newPage = new TabPage
            {
                Name = fileName,
                Text = tabText
            };

            TextBox newTextBox = new TextBox
            {
                Name = "txt" + fileName,
                Dock = DockStyle.Fill,
                Multiline = true,
                WordWrap = true,
                ScrollBars = ScrollBars.Vertical,
                ReadOnly = (fileIn ? false : true)
            };
            newPage.Controls.Add(newTextBox);

            return newPage;
        }
    }
}