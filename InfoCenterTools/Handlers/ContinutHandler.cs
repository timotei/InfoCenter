// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using InfoCenter.Classes;
using InfoCenter.Controls;
using InfoCenter.Util;
using Telerik.WinControls.UI;

namespace InfoCenter.Handlers
{
    /// <summary>
    /// Tine evidenta modificarilor in continut
    /// </summary>
    public sealed class ContinutHandler
    {
        #region Singleton
        private static ContinutHandler _Instance = new ContinutHandler();
        private ContinutHandler()
        {
            TesteContinut = new List<ContinutUpdate<Test>>();
            ProblemeContinut = new List<ContinutUpdate<Problema>>();
            IntrebariGrilaContinut = new List<ContinutUpdate<IntrebareGrila>>();
            IntrebariTestContinut = new List<ContinutUpdate<IntrebareTest>>();
            TipuriContinut = new List<ContinutUpdate<Tip>>();
            UnitatiTestareContinut = new List<ContinutUpdate<UnitateTestare>>();
        }
        public static ContinutHandler Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ContinutHandler();
                return _Instance;
            }
        }
        #endregion
        public List<ContinutUpdate<Test>>               TesteContinut { get; set; }
        public RadTreeNodeCollection                    LectiiContinut { get; set; }
        public List<ContinutUpdate<Problema>>           ProblemeContinut { get; set; }
        public List<ContinutUpdate<IntrebareTest>>      IntrebariTestContinut { get; set; }
        public List<ContinutUpdate<IntrebareGrila>>     IntrebariGrilaContinut { get; set; }
        public List<ContinutUpdate<Tip>>                TipuriContinut { get; set; }
        public List<ContinutUpdate<UnitateTestare>>     UnitatiTestareContinut { get; set; }

        /// <summary>
        /// Salveaza modificarile facute la continutul aplicatiei  si returneaza rezultatul operatiunii
        /// </summary>
        /// <returns></returns>
        public  bool SaveChanges()
        {
            return (SaveDatabase() && SaveFiles());
        }
        /// <summary>
        /// Restaureaza copiile de siguranta (baza de date, lectii), daca exista si reincarca informatiile
        /// </summary>
        /// <param name="reloadOnly">Adevarat daca se doareste doar reincarcare</param>
        /// <returns></returns>
        public  bool RestoreAll(bool reloadOnly)
        {
            return (RestoreDb(reloadOnly) && RestoreLectii(reloadOnly));
        }
        /// <summary>
        /// Realizeaza copii de siguranta (baza de date, fisiere)
        /// </summary>
        /// <returns></returns>
        public  bool BackupAll()
        {
            return (BackupDB() && BackupLectii());
        }

        /// <summary>
        /// Restaureaza copia de siguranta a bazei de date, daca exista, reincarca informatiile
        /// </summary>
        /// <param name="reloadOnly">Adevarat daca se doreste doar reincarcare</param>
        /// <returns></returns>
        internal bool RestoreDb(bool reloadOnly)
        {
            try
            {
                DatabaseHandler.Instance.CloseDBAcess();
                if (!reloadOnly)
                {
                    if (!RestoreFile(Config.DbFilePath))
                        return false;
                }

                DatabaseHandler.Instance.InitializeDBAcess(Config.DbConString);
                LoadingHandler.Instance.LoadDatabase(false);
                return true;
            }
            catch (Exception e)
            {
                ExceptionsHandler.Instance.AddException(e, Messages.ERROR_RESTORE_BACKUP);
                return false;
            }
        }
        /// <summary>
        /// Restaureaza copia de siguranta a lectiilor, daca exista, reincarca informatiile
        /// si returneaza rezultatul operatiunii
        /// </summary>
        /// <param name="reloadOnly">Adevarat daca se doreste doar reincarcarea nu si restaurarea</param>
        /// <returns></returns>
        internal bool RestoreLectii(bool reloadOnly)
        {
            try
            {
                if (!reloadOnly)
                {
                    if (RestoreFile(Config.LectiiListPath))
                        return false;
                }
                LoadingHandler.Instance.LoadFiles(false);
                Messages.ShowMessageBox(Messages.BACKUP_RESTORED_OK, "info");
                return true;
            }
            catch (Exception e)
            {
                ExceptionsHandler.Instance.AddException(e, Messages.ERROR_RESTORE_BACKUP);
                return false;
            }
        }
        /// <summary>
        /// Restaureaza un fisier specificat
        /// </summary>
        /// <param name="filePath">Calea catre fisier</param>
        /// <returns></returns>
        internal bool RestoreFile(string filePath)
        {
            string backupFilePath = Path.GetDirectoryName(filePath) + "\\" +
                Path.GetFileNameWithoutExtension(filePath) + ".bak";

            if (!File.Exists(backupFilePath))
            {
                Messages.ShowMessageBox(Messages.NO_BACKUP_EXISTING, "warn");
                return false;
            }

            File.Delete(filePath);
            File.Copy(backupFilePath, filePath);
            return true;
        }
        /// <summary>
        /// Salveaza baza de date pe disc
        /// </summary>
        internal bool SaveDatabase()
        {
            try
            {
                Logging.Instance.Write("UpdateContinut start.");

                #region Tipuri
                if (TipuriContinut.Count > 0)
                    Logging.Instance.Write("Tipuri");

                foreach (var continut in TipuriContinut)
                {
                    Tip tip = continut.CustomStruct;
                    if (tip == null)
                        continue;

                    var param = new OleDbParameter[3];
                    param[0] = new OleDbParameter("ID", tip.Id);
                    param[1] = new OleDbParameter("Nume", tip.Nume);
                    // sp_modify
                    param[2] = new OleDbParameter("IdToChange", tip.Id);
                    switch (continut.UpdateType)
                    {
                        case ContinutUpdateType.ADD:
                            DatabaseHandler.Instance.DoStoredProcNonQuery(DBStrings.INSERT_TIP, param);
                            break;
                        case ContinutUpdateType.DELETE:
                            DatabaseHandler.Instance.DoStoredProcNonQuery(DBStrings.DELETE_TIP,
                                new[] { new OleDbParameter("IdToDelete", tip.Id) });
                            break;
                        case ContinutUpdateType.MODIFY:
                            DatabaseHandler.Instance.DoStoredProcNonQuery(DBStrings.MODIFY_TIP, param);
                            break;
                        default:
                            break;
                    }
                    Logging.Instance.Write(continut.ToString());
                }
                TipuriContinut.Clear();
                #endregion
                #region Teste
                if (TesteContinut.Count > 0)
                    Logging.Instance.Write("Teste");

                foreach (var continut in TesteContinut)
                {
                    Test test = continut.CustomStruct;
                    if (test == null)
                        continue;

                    var param = new OleDbParameter[6];

                    // Test( ID, Tip, Titlu, Dificultate, punctajOficiu, tipPunctaj)
                    param[0] = new OleDbParameter("ID", test.Id);
                    param[1] = new OleDbParameter("Tip", test.Tip);
                    param[2] = new OleDbParameter("Titlu", test.Titlu);
                    param[3] = new OleDbParameter("Dificultate", test.Dificultate);
                    param[4] = new OleDbParameter("PunctajOficiu", test.PunctajOficiu);
                    // sp_modifiy
                    param[5] = new OleDbParameter("IdToChange", test.Id);
                    switch (continut.UpdateType)
                    {
                        case ContinutUpdateType.ADD:
                            DatabaseHandler.Instance.DoStoredProcNonQuery(DBStrings.INSERT_TEST, param);
                            break;

                        case ContinutUpdateType.DELETE:
                            DatabaseHandler.Instance.DoStoredProcNonQuery(DBStrings.DELETE_TEST_GRILA,
                                new[] { new OleDbParameter("IdToDelete", test.Id) });
                            break;

                        case ContinutUpdateType.MODIFY:
                            DatabaseHandler.Instance.DoStoredProcNonQuery(DBStrings.MODIFY_TEST, param);
                            break;
                        default:
                            continue;
                    }
                    Logging.Instance.Write(continut.ToString());
                }
                TesteContinut.Clear();
                #endregion
                #region Intrebari Grila
                if (IntrebariGrilaContinut.Count > 0)
                    Logging.Instance.Write("Intrebari Grila");

                foreach (var continut in IntrebariGrilaContinut)
                {
                    IntrebareGrila intrebare = continut.CustomStruct;
                    if (intrebare == null)
                        continue;

                    var param = new OleDbParameter[10];

                    // Test grila Intrebare ( ID, IdTest, Intrebare,rasp corect,r1,r2,r3,r4,puncte)
                    param[0] = new OleDbParameter("ID", intrebare.Id);
                    param[1] = new OleDbParameter("IDTest", intrebare.IdTest);
                    param[2] = new OleDbParameter("Intrebare", intrebare.Intrebare);
                    param[3] = new OleDbParameter("RaspunsCorect",
                        (int)(char)(intrebare.RaspunsCorect + intrebare.Id)); // codeaza raspunsul corect
                    param[4] = new OleDbParameter("Raspuns1", intrebare.Raspuns1);
                    param[5] = new OleDbParameter("Raspuns2", intrebare.Raspuns2);
                    param[6] = new OleDbParameter("Raspuns3", intrebare.Raspuns3);
                    param[7] = new OleDbParameter("Raspuns4", intrebare.Raspuns4);
                    param[8] = new OleDbParameter("Puncte", intrebare.Puncte);
                    // sp_modifiy
                    param[9] = new OleDbParameter("IdToChange", intrebare.Id);
                    switch (continut.UpdateType)
                    {
                        case ContinutUpdateType.ADD:
                            DatabaseHandler.Instance.DoStoredProcNonQuery(DBStrings.INSERT_TEST_INTREBAREGRILA, param);
                            break;

                        case ContinutUpdateType.DELETE:
                            DatabaseHandler.Instance.DoStoredProcNonQuery(DBStrings.DELETE_TEST_INTREBAREGRILA,
                                new[] { new OleDbParameter("IdToDelete", intrebare.Id) });
                            break;

                        case ContinutUpdateType.MODIFY:
                            DatabaseHandler.Instance.DoStoredProcNonQuery(DBStrings.MODIFY_TEST_INTREBAREGRILA, param);
                            break;
                        default:
                            continue;
                    }
                    Logging.Instance.Write(continut.ToString());
                }
                IntrebariGrilaContinut.Clear();
                #endregion
                #region Intrebari Test
                if (IntrebariTestContinut.Count > 0)
                    Logging.Instance.Write("Intrebari test");

                foreach (var continut in IntrebariTestContinut)
                {
                    IntrebareTest intrebare = continut.CustomStruct;
                    if (intrebare == null)
                        continue;

                    var param = new OleDbParameter[6];

                    // Test Intrebare ( ID, IdTest, Intrebare,rasp corect,puncte)
                    param[0] = new OleDbParameter("ID", intrebare.Id);
                    param[1] = new OleDbParameter("IDTest", intrebare.IdTest);
                    param[2] = new OleDbParameter("Intrebare", intrebare.Intrebare);
                    param[3] = new OleDbParameter("RaspunsCorect",
                        EncodingUtil.EncodeBase64(intrebare.RaspunsCorect,true)); // codeaza raspunsul corect
                    param[4] = new OleDbParameter("Puncte", intrebare.Puncte);
                    // sp_modifiy
                    param[5] = new OleDbParameter("IdToChange", intrebare.Id);

                    switch (continut.UpdateType)
                    {
                        case ContinutUpdateType.ADD:
                            DatabaseHandler.Instance.DoStoredProcNonQuery(DBStrings.INSERT_TEST_INTREBARE, param);
                            break;

                        case ContinutUpdateType.DELETE:
                            DatabaseHandler.Instance.DoStoredProcNonQuery(DBStrings.DELETE_TEST_INTREBARE,
                                new[] { new OleDbParameter("IdToDelete", intrebare.Id) });
                            break;

                        case ContinutUpdateType.MODIFY:
                            DatabaseHandler.Instance.DoStoredProcNonQuery(DBStrings.MODIFY_TEST_INTREBARE, param);
                            break;
                        default:
                            continue;
                    }
                    Logging.Instance.Write(continut.ToString());
                }
                IntrebariTestContinut.Clear();
                #endregion
                #region Probleme
                if (ProblemeContinut.Count > 0)
                    Logging.Instance.Write("Probleme");

                foreach (var continut in ProblemeContinut)
                {
                    Problema problema = continut.CustomStruct;
                    if (problema == null)
                        continue;

                    var param = new OleDbParameter[7];
                    // probleme ( ID, Tip, Titlu, Cerinta, Dificultate, CuvinteCheie)
                    param[0] = new OleDbParameter("ID", problema.Id);
                    param[1] = new OleDbParameter("Tip", problema.Tip);
                    param[2] = new OleDbParameter("Titlu", problema.Titlu);
                    param[3] = new OleDbParameter("Cerinta", problema.Cerinta);
                    param[4] = new OleDbParameter("Dificultate", problema.Dificultate);
                    param[5] = new OleDbParameter("CuvinteCheie", problema.CuvinteCheie);
                    // sp_modify
                    param[6] = new OleDbParameter("IdToChange", problema.Id);
                    switch (continut.UpdateType)
                    {
                        case ContinutUpdateType.ADD:
                            DatabaseHandler.Instance.DoStoredProcNonQuery(DBStrings.INSERT_PROBLEMA, param);
                            break;

                        case ContinutUpdateType.DELETE:
                            DatabaseHandler.Instance.DoStoredProcNonQuery(DBStrings.DELETE_PROBLEMA,
                                new[] { new OleDbParameter("IdToDelete", problema.Id) });
                            break;

                        case ContinutUpdateType.MODIFY:
                            DatabaseHandler.Instance.DoStoredProcNonQuery(DBStrings.MODIFY_PROBLEMA, param);
                            break;
                        default:
                            continue;
                    }
                    Logging.Instance.Write(continut.ToString());
                }
                ProblemeContinut.Clear();
                #endregion
                #region Unitati Testare
                if (UnitatiTestareContinut.Count > 0)
                    Logging.Instance.Write("Unitati Testare");
                foreach (var continut in UnitatiTestareContinut)
                {
                    UnitateTestare unitate = continut.CustomStruct;
                    if (unitate == null)
                        continue;

                    var param = new OleDbParameter[6];
                    // unitate testare (id,idproblema,nume,dateintrare,dateiesire)
                    param[0] = new OleDbParameter("ID",unitate.Id);
                    param[1] = new OleDbParameter("IDProblema", unitate.IdProblema);
                    param[2] = new OleDbParameter("Nume", unitate.Nume);
                    param[3] = new OleDbParameter("DateIntrare", unitate.DateIntrare);
                    param[4] = new OleDbParameter("DateIesire", unitate.DateIesire);
                    param[5] = new OleDbParameter("IdToChange", unitate.Id);

                    switch (continut.UpdateType)
                    {
                        case ContinutUpdateType.ADD:
                            DatabaseHandler.Instance.DoStoredProcNonQuery(DBStrings.INSERT_UNITATE_TESTARE, param);
                            break;
                        case ContinutUpdateType.DELETE:
                            DatabaseHandler.Instance.DoStoredProcNonQuery(DBStrings.DELETE_UNITATE_TESTARE,
                                new[] { new OleDbParameter("IdToDelete", unitate.Id) });
                            break;
                        case ContinutUpdateType.MODIFY:
                            DatabaseHandler.Instance.DoStoredProcNonQuery(DBStrings.MODIFY_UNITATE_TESTARE, param);
                            break;
                        default:
                            continue;
                    }
                    Logging.Instance.Write(continut.ToString());
                }
                #endregion
                Logging.Instance.Write("UpdateContinut finished");
            }
            catch (Exception e)
            {
                ExceptionsHandler.Instance.AddException(e, Messages.ERROR_SAVE_CHANGES);
                return false;
            }
            return true;
        }
        /// <summary>
        /// Salveaza fisierele cu continut pe disc
        /// </summary>
        internal bool SaveFiles()
        {
            try
            {
                LectiiHandler.Instance.LectiiHolder.Clear();
                LectiiHandler.Instance.LectiiHolder.Lectii = GetLectiiChildren(LectiiContinut);
                LectiiHandler.Instance.SaveFile();
                LectiiContinut = null;
            }
            catch (Exception e)
            {
                ExceptionsHandler.Instance.AddException(e, Messages.ERROR_SAVE_CHANGES);
                return false;
            }
            return true;
        }
        /// <summary>
        /// Returneaza o lista de Lectii convertite din Colectia de noduri de tip lectie specificata
        /// si returneaza rezultatul operatiunii
        /// </summary>
        /// <param name="nodes">Lista de noduri de tip lectie</param>
        /// <returns></returns>
        private  List<Lectie> GetLectiiChildren(RadTreeNodeCollection nodes)
        {
            if (nodes == null)
                return new List<Lectie>();

            var lista = new List<Lectie>();
            foreach (CustomTreeNode<Lectie> node in nodes)
            {
                if (node.CustomStruct == null)
                    continue;

                if (node.CustomStruct.Lectii == null)
                    node.CustomStruct.Lectii = new List<Lectie>();
                node.CustomStruct.Lectii.Clear();
                node.CustomStruct.Lectii.AddRange(GetLectiiChildren(node.Nodes));

                lista.Add(node.CustomStruct);
            }
            return lista;
        }
        /// <summary>
        /// Realizeaza o copie de siguranta a bazei de date si returneaza rezultatul operatiunii
        /// </summary>
        /// <returns></returns>
        internal bool BackupDB()
        {
            try
            {
                string backupFilePath = Path.GetDirectoryName(Config.DbFilePath) + "\\" +
                    Path.GetFileNameWithoutExtension(Config.DbFilePath) + ".bak";

                if (File.Exists(backupFilePath))
                    File.Delete(backupFilePath);

                File.Copy(Config.DbFilePath, backupFilePath);
                return true;
            }
            catch (Exception e)
            {
                ExceptionsHandler.Instance.AddException(e, Messages.ERROR_CREATE_BACKUP);
                return false;
            }
        }
        /// <summary>
        /// Realizeaza o copie de siguranta a lectiilor si returneaza rezultatul operatiunii
        /// </summary>
        /// <returns></returns>
        internal bool BackupLectii()
        {
            try
            {
                string backupFilePath = Path.GetDirectoryName(Config.LectiiListPath) + "\\" +
                    Path.GetFileNameWithoutExtension(Config.LectiiListPath) + ".bak";

                if (File.Exists(backupFilePath))
                    File.Delete(backupFilePath);

                File.Copy(Config.LectiiListPath, backupFilePath);
                Messages.ShowMessageBox(Messages.BACKUP_CREATED_OK, "info");
                return true;
            }
            catch (Exception e)
            {
                ExceptionsHandler.Instance.AddException(e, Messages.ERROR_CREATE_BACKUP);
                return false;
            }
        }

        /// <summary>
        /// Returneaza adevarat daca s-a modificat ceva in continut.
        /// </summary>
        /// <returns></returns>
        public bool HasModified()
        {
            return ( (LectiiContinut != null && LectiiContinut.Count > 0) || TesteContinut.Count > 0 || ProblemeContinut.Count > 0 ||
                    IntrebariGrilaContinut.Count > 0 || IntrebariTestContinut.Count > 0 || 
                    TipuriContinut.Count>0 || UnitatiTestareContinut.Count > 0);

        }
    }
}