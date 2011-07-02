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
using System.Linq;
using InfoCenter.Classes;
using InfoCenter.Controls;
using InfoCenter.Extensions;
using InfoCenter.Handlers;
using InfoCenter.Util;
using Res = InfoCenter.Handlers.ResourcesHandler;

namespace InfoCenter
{
    partial class MainForm
    {
        /// <summary>
        /// Incarca informatia pentru aplicatie
        /// </summary>
        private static void LoadingThread()
        {
            EventsHandler.Instance.AddEvent("loadingThread start", true);
            LoadingHandler.Instance.LoadDatabase(true);
            LoadingHandler.Instance.LoadFiles(true);
            Splasher.Status = Messages.LODING_APP;
            EventsHandler.Instance.AddEvent("loadingThread end", true);
        }
        /// <summary>
        /// Seteaza informatiile in program
        /// </summary>
        private void SetInformation()
        {
            FillTipuriGroups();
            EventsHandler.Instance.AddEvent("filled Tipuri", true);
            // Lectii
            FillLectii();
            cuprinsLectii.ExpandAll();
            EventsHandler.Instance.AddEvent("filled Lectii", true);

            // Probleme
            FillProbleme("", true);
            EventsHandler.Instance.AddEvent("filled cuvinte cheie", true);
            FillCuvinteCheie("", true);
            EventsHandler.Instance.AddEvent("filled cuvinte cheie", true);

            // Lectii
            FillTeste();
            listaTeste.ExpandAll();
            EventsHandler.Instance.AddEvent("filled teste", true);

            // selectare primul tab
            SelectTab(tabPageStart.Name);

            // adaugare ultimele elemente selectate
            foreach (var continut in Res.Instance.ListaContinutAccesat)
            {
                AddLastAccesItem(continut);
            }

            UpdateCompilerData();

            lblNumarLectii.Text = string.Format("Număr lecţii: {0}", Res.Instance.LectiiHolder.Count);
            lblNumarProbleme.Text = string.Format("Număr probleme: {0}", Res.Instance.ListaProbleme.Count);
            lblNumarTeste.Text = string.Format("Număr teste: {0}", Res.Instance.ListaTeste.Count);
            toolStripDataOra.Text = string.Format("| Data curentă: {0}", DateTime.Now.ToShortDateString());
        }

        /// <summary>
        /// Umple listele de tipuri
        /// </summary>
        private void FillTipuriGroups()
        {
            listaProbleme.Groups.AddRange(Res.Instance.ListaTipuri.ToListViewGroupArray());
        }
        /// <summary>
        /// Umple lista de lectii
        /// </summary>
        private void FillLectii()
        {
            cuprinsLectii.Nodes.Clear();
            cuprinsLectii.Nodes.AddRange(Res.Instance.GetCuprinsLectiiTreeNodes());
        }
        /// <summary>
        /// Umple lista de teste
        /// </summary>
        private void FillTeste()
        {
            listaTeste.Nodes.Clear();
            listaTeste.Nodes.AddRange(Res.Instance.GetTesteTreeNodes());
        }
        /// <summary>
        /// Umple lista cu probleme dupa sirul cautat
        /// </summary>
        /// <param name="searchText">Sirul cautat</param>
        /// <param name="init">Adevarat daca metoda este folosita pentru initializare</param>
        private void FillProbleme(string searchText, bool init)
        {
            if (searchText == " " || searchText == null)
                searchText = "";

            listaProbleme.Items.Clear();
            IEnumerable<Problema> result = from Problema problema in Res.Instance.ListaProbleme
                                           where problema.Titlu.Contains(searchText) &&
                                                problema.Cerinta.Contains(searchText)
                                           select problema;

            foreach (Problema problema in result)
                listaProbleme.Items.Add(new CustomListViewItem<Problema>(problema.Titlu,
                    problema, listaProbleme.Groups[problema.Tip]));

            listaProbleme.Sort();
            if (!init)
            {
                SelectTab(tabPageProbleme.Name);
                tabControlSubProbleme.SelectTab(tabPageListaProbleme);
            }
        }
        /// <summary>
        /// Umple lista cu cuvinte cheie dupa sirul cautat
        /// </summary>
        /// <param name="searchText">Sirul cautat</param>
        /// <param name="init">Adevarat daca metoda este folosita pentru initializare</param>
        private void FillCuvinteCheie(string searchText, bool init)
        {
            if (searchText == " " || searchText == null)
                searchText = "";

            // lista de cuvinte cheie
            var cuvinteList = new List<CustomTreeNode<CuvantCheie>>();
            // lista temporara de cuvinte cheie
            var currentCuvinte = new List<string>();
            listaCuvinteCheie.Nodes.Clear();

            foreach (Tip tip in Res.Instance.ListaTipuri)
            {
                cuvinteList.Clear();
                currentCuvinte.Clear();

                if (tip == null)
                    continue;

                var probleme = from Problema problema in Res.Instance.ListaProbleme
                               where problema.Tip.Equals(tip.Nume)
                               select problema;

                foreach (Problema problema in probleme)
                {
                    CuvantCheie cuvanteCheie = Res.Instance.GetCuvantCheieById(problema.Id);
                    if (!cuvanteCheie.Cuvinte.Contains(searchText))
                        continue;

                    string[] cuvinteCheieTmp = cuvanteCheie.Cuvinte.Split(',');
                    foreach (string cuvantCheie in cuvinteCheieTmp)
                    {
                        if (!cuvantCheie.Contains(searchText))
                            continue;

                        string cuvant = cuvantCheie.Trim();

                        if (!currentCuvinte.Contains(cuvant)) // nu exista introdus acest cuvant cheie
                        {
                            currentCuvinte.Add(cuvant);
                            var treeNode = new CustomTreeNode<CuvantCheie>(string.Format("{0} ({1})",
                                cuvant, 1), cuvanteCheie, false);
                            if (treeNode.ListaProbleme == null)
                                treeNode.ListaProbleme = new List<Problema>();

                            treeNode.ListaProbleme.Add(problema);
                            cuvinteList.Add(treeNode);
                        }
                        else
                        {
                            int index = currentCuvinte.IndexOf(cuvant);
                            var node = cuvinteList[index];

                            if (node.ListaProbleme == null)
                                node.ListaProbleme = new List<Problema>();
                            node.ListaProbleme.Add(problema);
                            node.Text = string.Format("{0} ({1})", cuvant, node.ListaProbleme.Count);
                        }
                    }
                }

                if (cuvinteList.Count > 0)
                    listaCuvinteCheie.Nodes.Add(new CustomTreeNode<CuvantCheie>(tip.Nume,
                        cuvinteList.ToArray(), null, true));
                else
                    Logging.Instance.Write("Problema fara cuvinte cheie");
            }
            listaCuvinteCheie.Sort();

            splitContainerCuvinteCheie.Panel2Collapsed = searchText.Length > 0;

            if (!init) // ne asiguram ca este selectat tab-ul potrivit
            {
                SelectTab(tabPageProbleme.Name);
                tabControlSubProbleme.SelectTab(tabPageCuvinteCheie);
            }
        }
    }
}