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
using Res = InfoCenter.Handlers.ResourcesHandler;
using InfoCenter.Controls;
using InfoCenter.Util;

namespace InfoCenter
{
    partial class MainForm
    {
        /// <summary>
        /// Seteaza starea Enabled a taburilor in timpul testului
        /// </summary>
        /// <param name="enabled">Adevarat daca sunt enabled</param>
        private void SetTabsEnabledStatus(bool enabled)
        {
            // ribbonbar tabs
            ribbonBar.CommandTabs[0].Tab.Enabled = ribbonBar.CommandTabs[1].Tab.Enabled = 
            ribbonBar.CommandTabs[2].Tab.Enabled= ribbonBar.CommandTabs[4].Tab.Enabled = enabled;            
        }

        /// <summary>
        /// Incepe testul selectat
        /// </summary>
        private void StartTest()
        {
            listaTeste.Enabled = false;
            SetTabsEnabledStatus(false);

            testTimer.Start();
            listaCorectareTest.Items.Clear();

            SetTestInformation();
        }

        /// <summary>
        /// Opreste testul selectat
        /// </summary>
        /// <param name="check">Daca e adevarat se va calcula si afisa punctajul obtinut</param>
        private void StopTest(bool check)
        {
            listaTeste.Enabled = true;
            SetTabsEnabledStatus(true);

            testTimer.Stop();
            TestHandler.Instance.Punctaj = 0;
            listaCorectareTest.Items.Clear();
            listaCorectareTest.Groups[0].Header = "";

            foreach (Control control in tabPageSubiectTest.Controls)
                if (control is TestGroupBox)
                {
                    var control2 = (control as TestGroupBox);
                    control2.ValidateRaspuns(true);

                    if (check)
                    {
                        float punctajAcordat = 0;
                        if (control2.ValidateRaspuns(false))
                        {
                            TestHandler.Instance.Punctaj += control2.Intrebare.Puncte;
                            punctajAcordat = control2.Intrebare.Puncte;
                        }

                        int nrCrt = control2.NrCrt;
                        // nr crt, raspuns utlizator, raspuns corect, puncte
                        var item = new ListViewItem(new[]
                                                        {
                                                            (nrCrt+1).ToString(), control2.Raspuns,
                                                            control2.Intrebare.RaspunsCorect, punctajAcordat.ToString()
                                                        });
                        listaCorectareTest.Items.Add(item);
                    }
                    control.Visible = false;
                }

            if (check)
            {
                //TestHandler.Instance.Punctaj += Res.Instance.SelectedTest.PunctajOficiu;
                listaCorectareTest.Items.Add(new ListViewItem(new[]
                                                                  {
                                                                      "", "Oficiu", "",
                                                                      Res.Instance.SelectedTest.PunctajOficiu.ToString()
                                                                  }));
                lblPunctaj.Text = "Punctaj: " + TestHandler.Instance.Punctaj;                
                listaCorectareTest.Sorting = SortOrder.Ascending;
                listaCorectareTest.Sort();
            }
            TestHandler.Instance.PunctajMaxim = Res.Instance.SelectedTest.PunctajMaxim;
            TestHandler.Instance.FinishedTest = true;
            ShowTestFinish(true);
        }

        /// <summary>
        /// Muta elementele din lista de teste aleatoriu
        /// </summary>
        private void RandomizeTestIntrebari()
        {
            var list = Res.Instance.SelectedTest.Intrebari;
            if (list == null)
                return;
            var newList = new List<IntrebareTest>();

            Random rnd = new Random();
            int tmpIndex;
            rnd.Next();
            rnd.Next();
            rnd = new Random(rnd.Next());

            for (int i = 0; i < list.Count; i++)
            {
                tmpIndex = rnd.Next(list.Count - 1);
                if (newList.Contains(list[tmpIndex]))
                    continue;
                newList.Add(list[tmpIndex]);
            }

            // adaugam restul elementelor ramase
            for (int i = 0; i < list.Count; i++)
                if (!newList.Contains(list[i]))
                    newList.Add(list[i]);

            Res.Instance.SelectedTest.Intrebari = newList;
        }

        /// <summary>
        /// Seteaza informatiile despre testul selectat (adauga intrebarile)
        /// </summary>
        private void SetTestInformation()
        {
            if (Res.Instance.SelectedTest == null)
                return;

            AddLastAccesItem(Res.Instance.SelectedTest);
            SetDifficultyImage(btnLblNivelTest, Res.Instance.SelectedTest.Dificultate);

            Test test = Res.Instance.SelectedTest;
            if (test == null)
                return;

            lblTitluTest.Text = test.Titlu;
            lblTitluTest.Visible = true;
            btnIntrebareAnterioara.Visible = btnIntrebareUrmatoare.Visible = true;

            btnIntrebareAnterioara.Enabled = false;
            btnIntrebareUrmatoare.Enabled = test.Intrebari.Count > 1;

            lblPunctaj.Text = "Punctaj - ";
            lblTimpScurs.Text = "Timp scurs: - ";

            // location pentru fiecare intrebare (sub titlu) + 10 = spatiu
            Point location = new Point(10, lblTitluTest.Location.Y + lblTitluTest.Height + 10);

            // Sterge controalele de dinainte
            List<Control> toDelete = new List<Control>();

            // fara label-ul cu Titlu si butoanele Inainte, Inapoi
            foreach (Control control in tabPageSubiectTest.Controls)
                if (!control.Name.Equals(lblTitluTest.Name) &&
                    !control.Name.Equals(btnIntrebareAnterioara.Name) &&
                    !control.Name.Equals(btnIntrebareUrmatoare.Name) &&
                    !control.GetType().Equals(typeof(Panel)))
                    toDelete.Add(control);

            foreach (Control control in toDelete)
                tabPageSubiectTest.Controls.Remove(control);

            RandomizeTestIntrebari();

            // Adauga intrebarile
            TestHandler.Instance.ListaIntrebari.Clear();
            int count = 0;

            foreach (IntrebareTest intrebare in test.Intrebari)
            {
                TestGroupBox group;

                if (intrebare.GetType().Equals(typeof(IntrebareGrila)))
                    group = new FrmIntrebareGrilaGroupBox(intrebare as IntrebareGrila);
                else
                    group = new FrmIntrebareTestGroupBox(intrebare);

                group.MaximumSize = new Size(tabPageSubiectTest.Width - 20, 600);
                group.MinimumSize = new Size(tabPageSubiectTest.Width - 20, 10);
                group.Location = location;
                group.SetIntrebareNr(count + 1);
                group.Name = "testGroup" + count + 1;
                group.NrCrt = count;
                group.Visible = false;

                tabPageSubiectTest.Controls.Add(group);
                TestHandler.Instance.ListaIntrebari.Add(group);
                count++;
            }

            SelectTab(tabPageTeste.Name);
            TestHandler.Instance.IntrebareCurenta = -1;
            TestHandler.Instance.PunctajOficiu = test.PunctajOficiu;
            ShowNextIntrebare();
            // prima intrebare, nu exista intrebare anterioara
            btnIntrebareAnterioara.Enabled = false;

            ShowTestWelcome(false);
            ShowTestFinish(false);
        }

        /// <summary>
        /// Afiseaza pe forma panoul de incepere al testului
        /// </summary>
        /// <param name="state">Starea panoului (Visible)</param>
        private void ShowTestWelcome(bool state)
        {
            panelWelcomeTest.Visible = state;
            if (state)
                tabControlSubTeste.SelectTab(0);
        }

        /// <summary>
        /// Afiseaza pe forma panoul de terminare al testului
        /// </summary>
        /// <param name="state">Starea panoului (Visible)</param>
        private void ShowTestFinish(bool state)
        {
            panelTestFinish.Visible = state;
            int percent = 0;
            if (TestHandler.Instance.Punctaj > 0)
                percent = (int)(TestHandler.Instance.Punctaj / TestHandler.Instance.PunctajMaxim * 100);
            lblTestTerminat.Text = string.Format(Messages.TEST_FINISH_PUNCTAJ,TestHandler.Instance.Punctaj,
                TestHandler.Instance.PunctajMaxim,TestHandler.Instance.PunctajOficiu, percent);

            if (state)
            {
                btnIntrebareAnterioara.Visible = btnIntrebareUrmatoare.Visible = false;
                btnIntrebareAnterioara.Enabled = btnIntrebareUrmatoare.Enabled = false;
                lblTitluTest.Visible = false;
            }
        }

        /// <summary>
        /// Afiseaza intrebarea dinaintea celei curente
        /// </summary>
        private void ShowPreviousIntrebare()
        {
            if (TestHandler.Instance.IntrebareCurenta > 0)
            {
                if (TestHandler.Instance.IntrebareCurenta >= 0)
                    TestHandler.Instance.ListaIntrebari[TestHandler.Instance.IntrebareCurenta].Visible = false;
                TestHandler.Instance.ListaIntrebari[TestHandler.Instance.IntrebareCurenta - 1].Visible = true;
                TestHandler.Instance.IntrebareCurenta -= 1;
            }

            btnIntrebareAnterioara.Enabled = (TestHandler.Instance.IntrebareCurenta > 0);
            btnIntrebareUrmatoare.Enabled = true;
            SetTestNavButtonsLocation();
        }

        /// <summary>
        /// Afiseaza urmatoarea intrebare
        /// </summary>
        private void ShowNextIntrebare()
        {

            if (TestHandler.Instance.IntrebareCurenta < TestHandler.Instance.ListaIntrebari.Count - 1)
            {
                if (TestHandler.Instance.IntrebareCurenta >= 0)
                    TestHandler.Instance.ListaIntrebari[TestHandler.Instance.IntrebareCurenta].Visible = false;
                TestHandler.Instance.ListaIntrebari[TestHandler.Instance.IntrebareCurenta + 1].Visible = true;
                TestHandler.Instance.IntrebareCurenta += 1;
            }
            else
                if (Messages.ShowMessageBox(Messages.CONFIRM_END_TEST[0],Messages.CONFIRM_END_TEST[1],
                    "question") == DialogResult.Yes)
                    btnCorecteazaTest.PerformClick();          
                        
            btnIntrebareAnterioara.Enabled = true;
            
            // nu mai am intrebari dupa (sunt la ultima)
            if (TestHandler.Instance.IntrebareCurenta < TestHandler.Instance.ListaIntrebari.Count - 1)
                btnIntrebareUrmatoare.Text = "Întrebarea următoare >";
            else
                btnIntrebareUrmatoare.Text = "Corectează testul";

            SetTestNavButtonsLocation();
        }

        /// <summary>
        /// Seteaza locatia corecta pentru butoanele de navigare in test
        /// </summary>
        private void SetTestNavButtonsLocation()
        {
            //btnIntrebareAnterioara.Visible = btnIntrebareUrmatoare.Visible = true;
            if (TestHandler.Instance.IntrebareCurenta >= 0 &&
                TestHandler.Instance.IntrebareCurenta < TestHandler.Instance.ListaIntrebari.Count)
            {
                int yPoint = lblTitluTest.Location.Y + lblTitluTest.Height + 30 +
                             TestHandler.Instance.ListaIntrebari[TestHandler.Instance.IntrebareCurenta].Height;

                btnIntrebareAnterioara.Location = new Point(btnIntrebareAnterioara.Location.X, yPoint);
                btnIntrebareUrmatoare.Location = new Point(btnIntrebareUrmatoare.Location.X, yPoint);
            }
        }
    }
}