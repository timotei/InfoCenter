// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System.Data.OleDb;
using System.Threading;
using InfoCenter.Classes;
using InfoCenter.Util;

namespace InfoCenter.Handlers
{
    /// <summary>
    /// Incarca informatia din baza de date in aplicatie pentru a putea fi folosita ulterior
    /// </summary>
    public sealed class LoadingHandler
    {
        #region Singleton
        private static LoadingHandler _Instance = new LoadingHandler();
        private LoadingHandler() { }
        public static LoadingHandler Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new LoadingHandler();
                return _Instance;
            }
        }
        #endregion
        /// <summary>
        /// Incarca informatia din baza de date
        /// </summary>
        /// <param name="async">Asincron sau nu</param>
        public  void LoadDatabase(bool async)
        {
            if (async)
            {
                Thread thread = new Thread(LoadDatabase) {Name = "LoadDatabase"};
                thread.Start();
            }
            else
                LoadDatabase();
        }
        /// <summary>
        /// Incarca informatia din fisiere
        /// </summary>
        /// <param name="async">Asincron sau nu</param>
        public  void LoadFiles(bool async)
        {
            if (async)
            {
                Thread thread = new Thread(LoadFiles) {Name = "LoadFiles"};
                thread.Start();
            }
            else
                LoadFiles();
        }

        /// <summary>
        /// Incarca baza de date
        /// </summary>
        private  void LoadDatabase()
        {
            EventsHandler.Instance.AddEvent("LoadDatabase started", true);

            Splasher.Status = Messages.LOADING_DB;
            DatabaseHandler.Instance.InitializeDBAcess(Config.DbConString);
            OleDbDataReader reader;

            #region Tipuri
            ResourcesHandler.Instance.ListaTipuri.Clear();
            using (reader = DatabaseHandler.Instance.DoStoredProcReader(DBStrings.SELECT_TIPURI, null))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        ResourcesHandler.Instance.IdsTipuri.Add(id);
                        ResourcesHandler.Instance.ListaTipuri.Add(new Tip(id, reader.GetString(1)));
                    }

                    reader.Close();
                }
                else
                    EventsHandler.Instance.AddEvent("Nu am incarcat nici un tip", false);
            }
            #endregion
            #region Probleme
            ResourcesHandler.Instance.ListaCuvinteCheie.Clear();
            ResourcesHandler.Instance.ListaProbleme.Clear();
            using (reader = DatabaseHandler.Instance.DoStoredProcReader(DBStrings.SELECT_PROBLEME, null))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        ResourcesHandler.Instance.IdsProbleme.Add(id);
                        // id 0, tip 1, titlu 2, cerinta 3, dificultate 4, cuvinte cheie 5
                        ResourcesHandler.Instance.ListaProbleme.Add(new Problema(id, reader.GetString(1), reader.GetString(2),
                            reader.GetString(3), reader.GetInt32(4), reader.GetString(5), Config.ProblemePath));

                        ResourcesHandler.Instance.ListaCuvinteCheie.Add(new CuvantCheie(id, reader.GetString(5)));
                    }

                    reader.Close();
                }
                else 
                    EventsHandler.Instance.AddEvent("Nu am incarcat nici o problema", false);
            }
            #endregion
            #region Teste
            ResourcesHandler.Instance.ListaTeste.Clear();
            using (reader = DatabaseHandler.Instance.DoStoredProcReader(DBStrings.SELECT_TESTE, null))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        int idTest = reader.GetInt32(0);
                        ResourcesHandler.Instance.IdsTeste.Add(idTest);

                        Test test = new Test(idTest, reader.GetString(1), reader.GetString(2), reader.GetInt32(3),
                            (float)reader.GetDouble(4), null);

                        // intrebari grila
                        OleDbDataReader reader2 = DatabaseHandler.Instance.DoStoredProcReader(
                            DBStrings.SELECT_TESTE_INTREBARIGRILA_BY_TEST,
                            new[] { new OleDbParameter("id", test.Id) });

                        if (reader2 != null)
                        {
                            while (reader2.Read())
                            {
                                int idIntrebare = reader2.GetInt32(0);
                                ResourcesHandler.Instance.IdsIntrebariGrila.Add(idIntrebare);

                                // decodeaza raspunsul corect
                                int raspunsCorect = reader2.GetInt32(3);
                                raspunsCorect = (char)(raspunsCorect - idIntrebare);

                                // id 0, idtest 1,intrebare 2, raspCorect 3, r1 r2 r3 r4 (4-7), puncte
                                test.Intrebari.Add(new IntrebareGrila(idIntrebare, idTest,
                                    reader2.GetString(2), raspunsCorect, reader2.GetString(4),
                                    reader2.GetString(5), reader2.GetString(6), reader2.GetString(7),
                                    (float)reader2.GetDouble(8)));
                            }
                        }
                        else 
                            EventsHandler.Instance.AddEvent("Nu am incarcat nici o intrebare grila pentru Testul" + test.Id, false);

                        // intrebari
                        reader2 = DatabaseHandler.Instance.DoStoredProcReader(
                            DBStrings.SELECT_TESTE_INTREBARI_BY_TEST,
                            new[] { new OleDbParameter("id", test.Id) });

                        if (reader2 != null)
                        {
                            while (reader2.Read())
                            {
                                int idIntrebare = reader2.GetInt32(0);
                                ResourcesHandler.Instance.IdsIntrebari.Add(idIntrebare);

                                // id 0, idtest 1,intrebare 2, raspCorect 3,puncte 4
                                test.Intrebari.Add(new IntrebareTest(idIntrebare, idTest,
                                    reader2.GetString(2), EncodingUtil.DecodeBase64(reader2.GetString(3),true),
                                    (float)reader2.GetDouble(4)));
                            }

                            reader2.Close();
                        }
                        else
                            EventsHandler.Instance.AddEvent("Nu am incarcat nici o intrebare pentru Testul" + test.Id, false);

                        ResourcesHandler.Instance.ListaTeste.Add(test);
                    }

                    reader.Close();
                }
                else
                    EventsHandler.Instance.AddEvent("Nu am incarcat nici un test", false);
            }
            #endregion
            #region Teste probleme
            ResourcesHandler.Instance.ListaUnitatiTestare.Clear();
            using (reader = DatabaseHandler.Instance.DoStoredProcReader(DBStrings.SELECT_UNITATI_TESTARE, null))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        // id ,idproblema,nume,dateintrare,dateiesire
                        int id = reader.GetInt32(0);
                        int idProblema = reader.GetInt32(1);
                        ResourcesHandler.Instance.IdsUnitatiTestare.Add(id);

                        var unitate = new UnitateTestare(id, idProblema, reader.GetString(2),
                            reader.GetString(3), reader.GetString(4));
                        ResourcesHandler.Instance.ListaUnitatiTestare.Add(unitate);
                    }

                    reader.Close();
                }
                else
                    EventsHandler.Instance.AddEvent("Nu am incarcat nici un test problema", false);
            }
            #endregion
            #region Continut Accesat
            ResourcesHandler.Instance.ListaContinutAccesat.Clear();
            using (reader = DatabaseHandler.Instance.DoStoredProcReader(DBStrings.SELECT_CONTINUT_ACCESAT, null))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        // id, idcontinut, tip continut
                        string tip = reader.GetString(2);
                        int idContinut = reader.GetInt32(1);
                        if (tip.Equals("test"))
                        {
                            ResourcesHandler.Instance.ListaContinutAccesat.Add(ResourcesHandler.Instance.GetTestById(idContinut));
                        }
                        else if (tip.Equals("problema"))
                        {
                            ResourcesHandler.Instance.ListaContinutAccesat.Add(ResourcesHandler.Instance.GetProblemaById(idContinut));
                        }
                        else if (tip.Equals("lectie"))
                        {
                            ResourcesHandler.Instance.ListaContinutAccesat.Add(ResourcesHandler.Instance.GetLectieById(idContinut));
                        }
                    }
                }
                else
                    EventsHandler.Instance.AddEvent("Nu am incarcat nici un continut accesat", false);
            }
            #endregion
            DatabaseHandler.Instance.CloseDBAcess();
            EventsHandler.Instance.AddEvent("LoadDatabase ended", true);
        }

        /// <summary>
        /// Incarca fisierele
        /// </summary>
        private  void LoadFiles()
        {
            EventsHandler.Instance.AddEvent("LoadFiles started", true);
            Splasher.Status = Messages.LOADING_FILES;
            ResourcesHandler.Instance.LoadLectiiFiles(Config.LectiiListPath);
            ResourcesHandler.Instance.LoadFragmenteDeCodFile(Config.FragmenteDeCodPath);
            EventsHandler.Instance.AddEvent("LoadFiles ended", true);
        }
    }
}