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
using System.Collections.Generic;
using System.Linq;
using InfoCenter.Classes;
using InfoCenter.Controls;
using InfoCenter.Util;
using System.Data.OleDb;

namespace InfoCenter.Handlers
{
    /// <summary>
    /// Tine evidenta resurselor necesare aplicatiei
    /// </summary>
    public sealed class ResourcesHandler
    {
        #region Singleton
        private static ResourcesHandler _Instance = new ResourcesHandler();
        private ResourcesHandler()
        {
            ListaContinutAccesat = new List<IContinut>();
            ListaCuvinteCheie = new List<CuvantCheie>();
            ListaProbleme = new List<Problema>();
            ListaTeste = new List<Test>();
            ListaTipuri = new List<Tip>();
            ListaUnitatiTestare = new List<UnitateTestare>();
            SelectedCompilerType = CompilerType.CPP;
        }
        public static ResourcesHandler Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ResourcesHandler();
                return _Instance;
            }
        }
        #endregion
        /// <summary>
        /// Lista ultimelor elemente de tip IContinut accesate
        /// </summary>
        public List<IContinut>      ListaContinutAccesat { get; set; }
        /// <summary>
        /// Lista problemelor
        /// </summary>
        public List<Problema>       ListaProbleme
        {
            get;
            set;
        }
        /// <summary>
        /// Lista cuvintelor cheie
        /// </summary>
        public List<CuvantCheie>    ListaCuvinteCheie { get; set; }
        /// <summary>
        /// Lista tipurilor
        /// </summary>
        public List<Tip>            ListaTipuri { get; set; }
        /// <summary>
        /// Lista testelor
        /// </summary>
        public List<Test>           ListaTeste { get; set; }
        /// <summary>
        /// Lista unitatilor testare
        /// </summary>
        public List<UnitateTestare> ListaUnitatiTestare { get; set; }
        /// <summary>
        /// Lista lectiilor
        /// </summary>
        public LectiiHolder         LectiiHolder
        {
            get { return LectiiHandler.Instance.LectiiHolder; }
        }
        /// <summary>
        /// Lista fragmentelor de cod
        /// </summary>
        public FragmenteDeCodHolder FragmenteDeCodHolder
        {
            get { return FragmenteDeCodHandler.Instance.FragmenteDeCod; }
        }
        /// <summary>
        /// Lectia selectata
        /// </summary>
        public Lectie               SelectedLectie { get; set; }
        /// <summary>
        /// Testul selectat
        /// </summary>
        public Test                 SelectedTest { get; set; }
        /// <summary>
        /// Problema selectata
        /// </summary>
        public Problema             SelectedProblema { get; set; }
        /// <summary>
        /// Id-urile problemelor selectate
        /// </summary>
        public string               SelectedProblemeIds { get; set; }
        /// <summary>
        /// Id-urile testelor selectate
        /// </summary>
        public string               SelectedTesteIds { get; set; }
        /// <summary>
        /// Sursa C++ selectata
        /// </summary>
        public string SelectedCPPSource = string.Empty;

        /// <summary>
        /// Lista cu id-uri distincte folosite de tipuri
        /// </summary>
        public HashSet<int> IdsTipuri = new HashSet<int>();
        /// <summary>
        /// Lista cu id-uri distincte folosite de lectii
        /// </summary>
        public HashSet<int> IdsLectii = new HashSet<int>();
        /// <summary>
        /// Lista cu id-uri distincte folosite de probleme
        /// </summary>
        public HashSet<int> IdsProbleme = new HashSet<int>();
        /// <summary>
        /// Lista cu id-uri distincte folosite de teste
        /// </summary>
        public HashSet<int> IdsTeste = new HashSet<int>();
        /// <summary>
        /// Lista cu id-uri distincte folosite de intrebari
        /// </summary>
        public HashSet<int> IdsIntrebari = new HashSet<int>();
        /// <summary>
        /// Lista cu id-uri distincte folosite de intrebari grila
        /// </summary>
        public HashSet<int> IdsIntrebariGrila = new HashSet<int>();
        /// <summary>
        /// Lista cu id-uri distincte folosite de unitatiile testare
        /// </summary>
        public HashSet<int> IdsUnitatiTestare = new HashSet<int>();
        /// <summary>
        /// Lista cu id-uri distincte folosite de fragmentele de cod
        /// </summary>
        public HashSet<int> IdsFragmenteDeCod = new HashSet<int>();


        /// <summary>
        /// Tipul compilatorului selectat
        /// </summary>
        public CompilerType SelectedCompilerType { get; set; }

        #region Files
        /// <summary>
        /// Incarca fisierele lectiilor
        /// </summary>
        /// <param name="lectiiPath">Locatia fisierului cu lectii</param>
        public void LoadLectiiFiles(string lectiiPath)
        {
            LectiiHandler.Instance.ParseFile(lectiiPath);
            AddLectiiIds(LectiiHandler.Instance.LectiiHolder.Lectii);
        }

        /// <summary>
        /// Incarca fisierele cu fragmentele de cod
        /// </summary>
        /// <param name="filePath">Locatia fisierului cu fragmente de cod</param>
        public void LoadFragmenteDeCodFile(string filePath)
        {
            FragmenteDeCodHandler.Instance.ParseFile(filePath);
        }

        /// <summary>
        /// Adauga id-urile folosite de lectii si sublectiile lor
        /// </summary>
        /// <param name="lista">Lista cu lectii</param>
        public void AddLectiiIds(List<Lectie> lista)
        {
            if (lista == null)
                return;

            foreach (Lectie lectie in lista)
            {
                IdsLectii.Add(lectie.Id);
                AddLectiiIds(lectie.Lectii);
            }
        }
        #endregion

        #region Database
        /// <summary>
        /// Returneaza un sir de CustomTreeNode cu lectiile din fisier
        /// </summary>
        /// <returns></returns>
        public CustomTreeNode<Lectie>[] GetCuprinsLectiiTreeNodes()
        {
            if (LectiiHolder == null)
                return new CustomTreeNode<Lectie>[0];

            var lista = new List<CustomTreeNode<Lectie>>();
            foreach (Lectie lectie in LectiiHolder.Lectii)
            {
                CustomTreeNode<Lectie> node;
                if (lectie.HasChildren)
                    node = new CustomTreeNode<Lectie>(lectie.Titlu, GetLectieSubNodes(lectie.Lectii),
                        lectie, false);
                else
                    node = new CustomTreeNode<Lectie>(lectie.Titlu, lectie, true);

                lista.Add(node);
            }
            return lista.ToArray();
        }

        /// <summary>
        /// Returneaza un sir de CustomTreeNode cu lista Testelor dupa id-urile specificate
        /// </summary>
        /// <param name="testeIds">Sirul de Id-uri</param>
        /// <returns></returns>
        public CustomTreeNode<Test>[] GetTesteTreeNodes(string testeIds)
        {
            var lista = new List<CustomTreeNode<Test>>();

            foreach (string id in testeIds.Split(','))
            {
                int testId;
                int.TryParse(id.Trim(), out testId);
                if (testId == 0)
                    continue;

                Test test = GetTestById(testId);
                lista.Add(new CustomTreeNode<Test>(test.Titlu, test, false));
            }
            return lista.ToArray();
        }

        /// <summary>
        /// Returneaza un CustomTreeNode cu toate Testele, categorisite dupa tip
        /// </summary>
        /// <returns></returns>
        public CustomTreeNode<Test>[] GetTesteTreeNodes()
        {
            var lista = new List<CustomTreeNode<Test>>();

            foreach (Tip tip in ListaTipuri)
            {
                if (tip == null)
                    continue;

                var testeList = from Test test in ListaTeste
                                where test.Tip.Equals(tip.Nume)
                                select new CustomTreeNode<Test>(test.Titlu, test, false);

                if (testeList.Count() > 0)
                    lista.Add(new CustomTreeNode<Test>(tip.Nume, testeList.ToArray(), null, true));
            }
            return lista.ToArray();
        }

        /// <summary>
        /// Returneaza problema cu ID-ul specificat, sau null daca nu exista una
        /// </summary>
        /// <param name="id">ID-ul problemei cautate</param>
        /// <returns></returns>
        public Problema GetProblemaById(int id)
        {
            return (ListaProbleme.Find(problema => problema.Id == id));
        }

        /// <summary>
        /// Returneaza cuvantul cheie cu ID-ul specificat, sau null daca nu exista una
        /// </summary>
        /// <param name="id">ID-ul Cuvantului cheie cautate</param>
        /// <returns></returns>
        public CuvantCheie GetCuvantCheieById(int id)
        {
            return (ListaCuvinteCheie.Find(cuvantCheie => cuvantCheie.Id == id));
        }

        /// <summary>
        /// Returneaza lista de sub-lectii a unei liste de lectii
        /// </summary>
        /// <param name="lectie">Lista de lectii</param>
        /// <returns></returns>
        private CustomTreeNode<Lectie>[] GetLectieSubNodes(List<Lectie> lectie)
        {
            if (lectie == null)
                return null;

            var listNodes = new List<CustomTreeNode<Lectie>>();

            foreach (Lectie subLectie in lectie)
            {
                CustomTreeNode<Lectie> node;
                if (subLectie.HasChildren)
                    node = new CustomTreeNode<Lectie>(subLectie.Titlu, GetLectieSubNodes(subLectie.Lectii),
                        subLectie, false);
                else
                    node = new CustomTreeNode<Lectie>(subLectie.Titlu, subLectie, true);
                listNodes.Add(node);
            }

            return listNodes.ToArray();
        }

        /// <summary>
        /// Returneaza Lectia cu id-ul specificat, sau null daca nu exista una
        /// </summary>
        /// <param name="id">Id-ul cautat</param>
        /// <returns></returns>
        public Lectie GetLectieById(int id)
        {
            return (LectiiHolder.Lectii.Find(lectie => lectie.Id == id));
        }

        /// <summary>
        /// Returneaza testul cu ID-ul specificat, sau null daca nu exista unul
        /// </summary>
        /// <param name="id">Id-ul cautat</param>
        /// <returns></returns>
        public Test GetTestById(int id)
        {
            return (ListaTeste.Find(test => test.Id == id));
        }

        /// <summary>
        /// Returneaza unitatile de testare ale problemei cu ID-ul specificat
        /// </summary>
        /// <param name="id">Id-ul problemei</param>
        /// <returns></returns>
        public List<UnitateTestare> GetUnitatiTestareByProblema(int id)
        {
            return (from UnitateTestare unitate in ListaUnitatiTestare
                    where unitate.IdProblema == id
                    select unitate).ToList();
        }

        /// <summary>
        /// Sterge toate referintele referitoare la lectia specificata
        /// </summary>
        /// <param name="lectie"></param>
        public void RemoveLectie(Lectie lectie)
        {
            if (lectie == null)
                return;

            IdsLectii.Remove(lectie.Id);
            LectiiHolder.Lectii.Remove(lectie);

            if (lectie.Lectii == null)
                lectie.Lectii = new List<Lectie>();

            foreach (var sublectie in lectie.Lectii)
            {
                RemoveLectie(sublectie);
            }
        }

        /// <summary>
        /// Sterge toate referintele referitoare la testul specificat
        /// </summary>
        public void RemoveTest(Test test)
        {
            if (test == null)
                return;

            IdsTeste.Remove(test.Id);
            ListaTeste.Remove(test);
            ContinutHandler.Instance.TesteContinut.Add(new ContinutUpdate<Test>(test,
                ContinutUpdateType.DELETE));

            foreach (var intrebare in test.Intrebari)
            {
                if (intrebare.GetType() == typeof(IntrebareGrila))
                {
                    ContinutHandler.Instance.IntrebariGrilaContinut.Add(new ContinutUpdate<IntrebareGrila>(
                        (intrebare as IntrebareGrila), ContinutUpdateType.DELETE));
                    IdsIntrebariGrila.Remove(intrebare.Id);
                }
                else if (intrebare.GetType() == typeof(IntrebareTest))
                {
                    ContinutHandler.Instance.IntrebariTestContinut.Add(new ContinutUpdate<IntrebareTest>(
                        intrebare , ContinutUpdateType.DELETE));
                    IdsIntrebari.Remove(intrebare.Id);
                }
            }
        }

        /// <summary>
        /// Sterge toate referintele referitoare la problema specificata
        /// </summary>
        public void RemoveProblema(Problema problema)
        {
            if (problema == null)
                return;

            ContinutHandler.Instance.ProblemeContinut.Add(new ContinutUpdate<Problema>
                (SelectedProblema, ContinutUpdateType.DELETE));
            IdsProbleme.Remove(problema.Id);
            ListaProbleme.Remove(problema);
        }

        /// <summary>
        /// Actualizeaza fisierele cu fragmente de cod
        /// </summary>
        public void UpdateFragmenteDeCod()
        {
            FragmenteDeCodHandler.Instance.SaveFile();
        }

        /// <summary>
        /// Adauga in baza de date ultimele elemente accesate.
        /// </summary>
        /// <param name="items"></param>
        public void UpdateContinutAccesat(Telerik.WinControls.RadItemOwnerCollection items)
        {
            DatabaseHandler.Instance.DoStoredProcNonQuery(DBStrings.DELETE_CONTINUT_ACCESAT, null);

            foreach (var item in items)
            {
                var param = new[] {  new OleDbParameter("IDContinut", ""), 
                                                    new OleDbParameter("Tip", "") };
                if (item.KeyTip.ToLower().Equals("problema"))
                {
                    if (item is CustomRadItem<Problema>)
                    {
                        param[0].Value = ((CustomRadItem<Problema>)item).CustomStruct.Id;
                        param[1].Value = "problema";
                    }
                }
                else if (item.KeyTip.ToLower().Equals("lectie"))
                {
                    if (item is CustomRadItem<Lectie>)
                    {
                        param[0].Value = ((CustomRadItem<Lectie>)item).CustomStruct.Id;
                        param[1].Value = "problema";
                    }
                }
                else if (item.KeyTip.ToLower().Equals("test"))
                {
                    if (item is CustomRadItem<Test>)
                    {
                        param[0].Value = ((CustomRadItem<Test>)item).CustomStruct.Id;
                        param[1].Value = "problema";
                    }
                }
                else continue;

                DatabaseHandler.Instance.DoStoredProcNonQuery(DBStrings.INSERT_CONTINUT_ACCESAT, param);
            }
        }
        #endregion

        #region ID management
        /// <summary>
        /// Returneaza urmatorul ID valabil pentru lectii
        /// </summary>
        /// <returns></returns>
        public int GetNextAvailableLectieId()
        {
            return GetNextAvailableId(IdsLectii);
        }

        /// <summary>
        /// Returneaza urmatorul ID valabil pentru probleme
        /// </summary>
        /// <returns></returns>
        public int GetNextAvailableProblemaId()
        {
            return GetNextAvailableId(IdsProbleme);
        }

        /// <summary>
        /// Returneaza urmatorul ID valabil pentru teste
        /// </summary>
        /// <returns></returns>
        public int GetNextAvailableTestId()
        {
            return GetNextAvailableId(IdsTeste);
        }

        /// <summary>
        /// Returneaza urmatorul ID valabil pentru intrebarile grila
        /// </summary>
        /// <returns></returns>
        public int GetNextAvailableIntrebareGrilaId()
        {
            return GetNextAvailableId(IdsIntrebariGrila);
        }

        /// <summary>
        /// Returneaza urmatorul ID valabil pentru intrebari
        /// </summary>
        /// <returns></returns>
        public int GetNextAvailableIntrebareId()
        {
            return GetNextAvailableId(IdsIntrebari);
        }

        /// <summary>
        /// Returneaza urmatorul ID valabil pentru tipuri
        /// </summary>
        /// <returns></returns>
        public int GetNextAvailableTipId()
        {
            return GetNextAvailableId(IdsTipuri);
        }

        /// <summary>
        /// Returneaza urmatorul ID valabil pentru unitatile de testare
        /// </summary>
        /// <returns></returns>
        public int GetNextAvailableUnitateTestareId()
        {
            return GetNextAvailableId(IdsUnitatiTestare);
        }

        /// <summary>
        /// Returneaza urmatorul ID valabil pentru fragmentele de cod
        /// </summary>
        /// <returns></returns>
        public int GetNextAvailableFragmentDeCodId()
        {
            return GetNextAvailableId(IdsFragmenteDeCod);
        }

        /// <summary>
        /// Returneaza urmatorul ID valabil dintr-o lista de ID-uri specificate
        /// </summary>
        /// <param name="intList">Lista de ID-uri tip
        /// <returns></returns>
        private int GetNextAvailableId(HashSet<int> intList)
        {
            IEnumerable<int> orderedList = intList.OrderBy(id => id);
            int nrBefore = 0;

            foreach (int nr in orderedList)
            {
                if (nr - nrBefore > 1)
                    break;
                nrBefore = nr;
            }
            return nrBefore + 1;
        }
        #endregion
    }
}