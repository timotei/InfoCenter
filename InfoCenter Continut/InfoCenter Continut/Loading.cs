// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
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
        /// Thread pentru incarcarea informatiilor necesare
        /// </summary>
        private void LoadingThread()
        {
            DatabaseHandler.Instance.InitializeDBAcess(Config.DbConString);
            LoadingHandler.Instance.LoadDatabase(false);
            LoadingHandler.Instance.LoadFiles(false);
        }
        /// <summary>
        /// Se executa dupa ce s-au incarcat toate informatiile in aplicatie
        /// </summary>
        private void LoadingFinished()
        {
            FillTipuriGroups(false);
            FillLectii();
            FillProbleme("");
            FillTeste();

            treeViewLectii.ExpandAll();
            treeViewTeste.ExpandAll();

            lblNumarLectii.Text = "Număr lecţii: " + Res.Instance.LectiiHolder.Count;
            lblNumarProbleme.Text = "Număr probleme: " + Res.Instance.ListaProbleme.Count;
            lblNumarTesteGrila.Text = "Număr teste: " + Res.Instance.ListaTeste.Count;

            comboBoxDificultateProblema.Text = comboBoxDificultateLectie.Text = comboBoxDificultateTest.Text = "1";
            comboBoxTipProblema.Text = comboBoxTipTest.Text = "<nespecificat>";

            documentProbleme.Activated += DocumentProblemeClick;
            documentTablouDeBord.Activated += DocumentTablouDeBordClick;
            documentTest.Activated += DocumentTestClick;
            documentLectii.Activated += DocumentLectiiClick;
        }
        /// <summary>
        /// Umple lista cu grupuri de tipuri
        /// </summary>
        /// <param name="modified">Adevarat daca s-au modificat tipurile(fals - incarcarea initiala)</param>
        private void FillTipuriGroups(bool modified)
        {
            comboBoxTipProblema.Sorted = true;
            comboBoxTipTest.Sorted = true;

            comboBoxTipProblema.Items.Clear();
            comboBoxTipTest.Items.Clear();

            listaProbleme.Groups.Add(new ListViewGroup("<nespecificat>", "<nespecificat>"));
            comboBoxTipTest.Items.Add("<nespecificat>");
            comboBoxTipProblema.Items.Add("<nespecificat>");

            comboBoxTipProblema.Items.AddRange(Res.Instance.ListaTipuri.AsStringArray());
            comboBoxTipTest.Items.AddRange(Res.Instance.ListaTipuri.AsStringArray());

            if (!modified)
            {
                listaProbleme.Groups.AddRange(Res.Instance.ListaTipuri.ToListViewGroupArray());
            }
            else
            {
                ListViewGroup unspecifiedGroup = listaProbleme.Groups["<nespecificat>"];
                if (unspecifiedGroup == null)
                    return;

                // fix lista problema
                foreach (CustomListViewItem<Problema> problema in listaProbleme.Items)
                {
                    if (Res.Instance.ListaTipuri.ContainsTip(problema.Group.Name) ||
                        problema.Group.Name.Equals("<nespecificat>"))
                        continue;
                    problema.Group = unspecifiedGroup;
                }

                // fix lista teste grila
                var listToDelete = new List<CustomTreeNode<Test>>();                
                foreach (CustomTreeNode<Test> tipTest in treeViewTeste.Nodes)
                {
                    if (Res.Instance.ListaTipuri.ContainsTip(tipTest.Text))
                        continue;
                    // tipul nu exista
                    CreateParentNode<Test>(treeViewTeste, "<nespecificat>");
                    treeViewTeste.Nodes["<nespecificat>"].Nodes.AddRange(tipTest.Nodes.ToList());
                    listToDelete.Add(tipTest);
                }

                foreach (var item in listToDelete)
                {
                    treeViewLectii.Nodes.Remove(item);
                }
            }
        }
        /// <summary>
        /// Umple lista cu lectii
        /// </summary>
        private void FillLectii()
        {
            treeViewLectii.Nodes.Clear();
            treeViewLectii.Nodes.AddRange(Res.Instance.GetCuprinsLectiiTreeNodes());
        }
        /// <summary>
        /// Umple lista cu teste 
        /// </summary>
        private void FillTeste()
        {
            treeViewTeste.Nodes.Clear();
            treeViewTeste.Nodes.AddRange(Res.Instance.GetTesteTreeNodes());
        }
        /// <summary>
        /// Umple lista cu probleme dupa sirul cautat.
        /// </summary>
        /// <param name="searchText">Textul cautat in titlu</param>
        private void FillProbleme(string searchText)
        {
            if (searchText == " " || searchText == null)
                searchText = "";

            listaProbleme.Items.Clear();
            IEnumerable<Problema> result = from Problema problema in Res.Instance.ListaProbleme
                                           where problema.Titlu.Contains(searchText)
                                           select problema;
            foreach (Problema problema in result)
                listaProbleme.Items.Add(new CustomListViewItem<Problema>(
                    problema.Titlu, problema, listaProbleme.Groups[problema.Tip]));

            listaProbleme.Sort();
        }

    }
}
