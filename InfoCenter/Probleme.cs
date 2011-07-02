// Copyright � 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System;
using System.IO;
using InfoCenter.Classes;
using InfoCenter.Handlers;
using InfoCenter.Util;
using Res = InfoCenter.Handlers.ResourcesHandler;
using System.Windows.Forms;
using InfoCenter.Controls;

namespace InfoCenter
{
    partial class MainForm
    {
        /// <summary>
        /// Seteaza informatiile despre problema selectata
        /// </summary>
        private void SetProblemaInformation()
        {
            if (Res.Instance.SelectedProblema == null)
                return;

            AddLastAccesItem(Res.Instance.SelectedProblema);
            Problema problema = Res.Instance.SelectedProblema;
            SetDifficultyImage(lblDificultateProblema, problema.Dificultate);

            txtCerintaProblema.Text = problema.Cerinta;
            txtSursaProblema.Text = "";

            try
            {
                string fileName;
                if (Res.Instance.SelectedCompilerType == CompilerType.CPP)
                {
                    fileName = problema.LocatieCPP;
                }
                else
                {
                    txtSursaProblema.Text = Messages.NO_PROBLEM_REZOLVARE_EXIST;
                    return;
                }

                using (StreamReader sr = new StreamReader(fileName))
                {
                    txtSursaProblema.Text = sr.ReadToEnd();
                    switch (Res.Instance.SelectedCompilerType)
                    {
                        case CompilerType.CPP:
                            txtSursaProblema.SourceTextBox.SetHighlighting("C++.NET");
                            break;
                        default:
                            txtSursaProblema.SourceTextBox.SetHighlighting("");
                            break;
                    }
                }

                SetUnitatiTestare();

                SelectTab(tabPageProbleme.Name);
            }
            catch (FileNotFoundException fnfe)
            {
                ExceptionsHandler.Instance.AddException(fnfe, "");
                EventsHandler.Instance.AddEvent(Messages.SOURCE_FILE_NOT_FOUND, false);
                SetStatusLabelState(Messages.SOURCE_FILE_NOT_FOUND, 1);
            }
            catch (Exception e)
            {
                ExceptionsHandler.Instance.AddException(e, "");
            }
        }
        /// <summary>
        /// Seteaza testele care le contine problema
        /// </summary>
        private void SetUnitatiTestare()
        {
            if (Res.Instance.SelectedProblema == null)
                return;
            gridVerificare.Rows.Clear();
            var listaUnitatiTestare = Res.Instance.GetUnitatiTestareByProblema(Res.Instance.SelectedProblema.Id);

            gridVerificare.Visible = listaUnitatiTestare.Count > 0;

            foreach (var unitate in listaUnitatiTestare)
            {
                gridVerificare.Rows.Add(unitate, "", "", "");
            }
        }

        /// <summary>
        /// Selecteaza problema din ListViewItem si afiseaza informatiile
        /// </summary>
        /// <param name="listItem"></param>
        private void SelectProblema(ListViewItem listItem)
        {
            if (listItem == null)
                return;
            var item = listItem as CustomListViewItem<Problema>;
            if (item == null)
                return;

            Res.Instance.SelectedProblema = item.CustomStruct;
            SetProblemaInformation();
        }
    }
}