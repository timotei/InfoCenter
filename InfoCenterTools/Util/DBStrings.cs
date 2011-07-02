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
