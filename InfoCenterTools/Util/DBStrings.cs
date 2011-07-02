// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk

namespace InfoCenter.Util
{
    /// <summary>
    /// Tine evidenta query-urilor si view-urilor folosite in baza de date
    /// </summary>
    public static class DBStrings
    {
        // Delete
        public static string DELETE_PROBLEMA =                      "sp_deleteProblema";
        public static string DELETE_TEST_GRILA =                    "sp_deleteTest";
        public static string DELETE_TEST_INTREBARE =                "sp_deleteIntrebare";
        public static string DELETE_TEST_INTREBAREGRILA =           "sp_deleteIntrebareGrila";
        public static string DELETE_TEST_INTREBARE_BY_TEST =        "sp_deleteIntrebareByTest";
        public static string DELETE_TEST_INTREBAREGRILA_BY_TEST =   "sp_deleteIntrebareGrilaByTest";
        public static string DELETE_TIP =                           "sp_deleteTip";
        public static string DELETE_UNITATE_TESTARE =               "sp_deleteUnitateTestare";
        public static string DELETE_CONTINUT_ACCESAT =              "sp_deleteContinutAccesat";

        // Insert
        public static string INSERT_PROBLEMA =                      "sp_insertProblema";
        public static string INSERT_TEST =                          "sp_insertTest";
        public static string INSERT_TEST_INTREBARE =                "sp_insertIntrebare";
        public static string INSERT_TEST_INTREBAREGRILA =           "sp_insertIntrebareGrila";
        public static string INSERT_TIP =                           "sp_insertTip";
        public static string INSERT_UNITATE_TESTARE =               "sp_insertUnitateTestare";
        public static string INSERT_CONTINUT_ACCESAT =              "sp_insertContinutAccesat";

        // Modify
        public static string MODIFY_PROBLEMA =                      "sp_modifyProblema";
        public static string MODIFY_TEST =                          "sp_modifyTest";
        public static string MODIFY_TEST_INTREBARE =                "sp_modifyIntrebare";
        public static string MODIFY_TEST_INTREBAREGRILA =           "sp_modifyIntrebareGrila";
        public static string MODIFY_TIP =                           "sp_modifyTip";
        public static string MODIFY_UNITATE_TESTARE =               "sp_modifyUnitateTestare";

        // Select
        public static string SELECT_PROBLEME =                      "sp_selectProbleme";
        public static string SELECT_TESTE =                         "sp_selectTeste";
        public static string SELECT_TESTE_INTREBARI =               "sp_selectaIntrebari";
        public static string SELECT_TESTE_INTREBARI_BY_TEST =       "sp_selectIntrebariByTest";
        public static string SELECT_TESTE_INTREBARIGRILA =          "sp_selectIntrebariGrila";
        public static string SELECT_TESTE_INTREBARIGRILA_BY_TEST =  "sp_selectIntrebariGrilaByTest";
        public static string SELECT_UNITATI_TESTARE =               "sp_selectUnitatiTestare";
        public static string SELECT_UNITATI_TESTARE_BY_PROBLEMA =   "sp_selectUnitatiTestareByProblema";
        public static string SELECT_TIPURI =                        "sp_selectTipuri";
        public static string SELECT_CONTINUT_ACCESAT =              "sp_selectContinutAccesat";
    }
}
