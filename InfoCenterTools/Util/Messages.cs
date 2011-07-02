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
using Telerik.WinControls;
using System.Windows.Forms;
using InfoCenter.Controls;

namespace InfoCenter.Util
{
    /// <summary>
    /// Tine evidenta mesajelor afisate utilizatorului
    /// </summary>
    public static class Messages
    {
        public static string FILE_NOT_FOUND                 = "Fişierul nu a fost găsit.";
        public static string FILE_NOT_FOUND_REQUIRED        = "Un fişier necesar nu a fost găsit.";
        public static string SETTINGS_SAVED                 = "Setările au fost salvate.";
        public static string SETTINGS_NOT_SAVED             = "Unele setări nu au fost salvate.";
        // InfoCenter
        public static string LOADING                        = "Se incarcă ...";
        public static string LODING_APP                     = "Se încarcă aplicaţia...";
        public static string LOADING_DB                     = "Se încarcă baza de date...";
        public static string LOADING_SETTINGS               = "Se încarcă setările...";
        public static string LOADING_FILES                  = "Se încarcă fişierele...";
        public static string LOADING_UPDATE_CONTINUT        = "Se încarcă informaţiile modificate.";
        public static string LOADING_FINISHED               = "Informaţiile au fost re-încărcate.";
        public static string LOADING_LECTIE                 = "Se încarcă lecţia...";

        public static string SOURCE_FILE_NOT_FOUND          = "Fişierul cod sursă nu a fost găsit.";
        public static string LECTIE_FILE_NOT_FOUND          = "Fişierul asociat lecţiei nu există.";

        public static string LECTIE_FILE_LOADED             = "Fişierul asociat lecţiei a fost afişat.";
        public static string SOURCE_FILE_LOADED             = "Fişierul cod sursă a fost afişat.";

        public static string FILE_SAVED                     = "Fişierul a fost salvat.";

        public static string QUICK_SAVE_FOLDER_NOT_DEFINED  = "Locaţia pentru salvare rapidă nu a fost setată. O puteţi seta din Opţiuni.";
        public static string COMPILER_DEFINED_NOT_VALID     = "Locaţia executabilului compilatorului nu a fost definită sau nu este validă. Pentru a putea compila programele trebuie să definiţi locaţia executabilului.";

        public static string COMPILER_EXE_NOT_FOUND         = "Executabilul compilatorului nu a fost găsit. Vă rog verificaţi încă odată locaţia acestuia.";
        public static string QUICK_SAVE_FOLDER_NOT_FOUND    = "Dosarul pentru salvare rapidă nu a fost găsit. Vă rog verificaţi incă odată.";

        public static string COMPILING_STARTED              = "Se compilează programul...";
        public static string WAITING_FOR_EXECUTE_EXIT       = "Aştept să se închidă programul compilat...";
        public static string COMPILE_STARTED                = "Compilarea a fost iniţiată odată. Aşteptaţi până se termină.";
        public static string COMPILING_FINISHED_OK          = "Programul s-a compilat cu succes.";
        public static string COMPILING_FINISHED_ERROR       = "Au fost întâmpinate erori la compilarea programului.";
        public static string COMPILING_FINISHED_WARN        = "Atenţie! Programul conţine erori de compilare.";

        public static string NO_PROBLEM_REZOLVARE_EXIST     = "Nu există rezolvări pentru această problemă.";
        public static string INVALID_COMPILER_SELECTED      = "A fost selectat un compilator inexistent.";

        public static string[] NO_TEST_SELECTED_ARRAY       = new []{
            "Nu aţi selectat nici un test. Trebuie să selectaţi unul înainte de a folosi această funcţie.",
            "Nu aţi selectat nici un test"
        };

        public static string[] NO_LECTIE_SELECTED_ARRAY     = new []{
            "Nu aţi selectat nici o lecţie. Trebuie să selectaţi una înainte de a folosi această funcţie.",
            "Nu aţi selectat nici o lecţie"
        };
        public static string[] NO_PROBLEMA_SELECTED_ARRAY   = new []{
            "Nu aţi selectat nici o problemă. Trebuie să selectaţi una înainte de a folosi această funcţie.",
            "Nu aţi selectat nici o problemă"
        };

        public static string[] EXISTING_SOURCE_CODE_ARRAY   = new [] {
            "Există cod scris în compilator. Scrieţi peste?",
            "Există cod scris"
        };
        public static string[] PRINT_PREVIEW_ARRAY          = new []{
            "Doriţi să previzualizaţi documentul înainte de imprimare?",
            "Previzualizaţi?"
        };
        public static string[] NO_CONSOLE_IN_TEXT_ARRAY     = new[] {
            "Nu aţi introdus nici o informaţie în câmpul pentru \"Console In\". Este posibil ca programul compilat să nu primească informaţiile necesare. Continuaţi?",
            "Continuaţi fără a introduce informaţiile?"
        };
        public static string PROGRAM_TERMINATED_TOO_LONG    = 
            "Programul compilat a fost închis deoarece a depăşit perioada de 5 secunde admisă. "+
            "(Aceasta se poate datora în principal datorită faptului că nu au fost introduse (destule)"+
            "date de intrare. Încercaţi din nou.";
        public static string TEST_FINISH_PUNCTAJ            = "<html>Ai terminat testul cu un punctaj de: {0} din {1} (total:{3}%)<br>                                      Felicitări!<br><br>";

        public static string COMPILER_ARGS_DETAILS          = "Ordinea de specificare a argumentelor este" +
            " următoarea: primul argument ( {0} ) se va înlocui cu numele fişierului sursă (e.g.: fisier.cpp)" +
            ", al doilea argument ( {1} ) se va înlocui cu numele fişierului compilat (e.g.: fisier.exe)." +
            " Dacă folosiţi compilatorul Microsoft nu este necesar al 2-lea argument.";

        public static string ERROR_WRITING_DATE_INTRARE     = "Am întâmpinat o eroare încercând să"+
            " scriu datele de intrare";

        public static string[] CONFIRM_END_TEST             = new[]{
            "Sunteţi siguri că aţi terminat testul?",
            "Corectaţi testul?"
        };

        public static string NO_INPUT_PROVIDED              = "Nu aţi specificat nici o valoare pentru"
            + " Console In. Dacă programul nu primeşte destule informaţii se va bloca.";

        public static string NO_UPDATE_NEEDED               = "Aplicaţia este actualizată.";
        public static string UPDATING_SEARCH                = "Caut dupa versiuni mai noi ale aplicaţiei...";
        public static string UPDATING_STARTED               = "Actualizarea a început...";
        public static string UPDATING_FINISHED_OK           = "Actualizarea s-a terminat cu succes.";
        public static string UPDATING_FINISHED_ERROR        = "Am întâmpinat erori în timpul actualizării.";

        public static string INVALID_ARCHIVE                = "Arhivă invalidă.";


        // Info Center continut
        public static string TEST_ALREADY_ADDED             = "Aţi adăugat deja aceast test.";
        public static string PROBLEMA_ALREADY_ADDED         = "Aţi adăugat deja această problemă.";
        public static string LECTIE_ALREADY_ADDED           = "Aţi adăugat deja această lecţie.";

        public static string INFORMATION_SAVED              = "Modificările au fost salvate.";
        public static string NO_BACKUP_EXISTING             = "Nu există nici o copie de sigurantă făcută.";
        public static string BACKUP_CREATED_OK              = "Copie de siguranţă creată cu succes.";
        public static string BACKUP_RESTORED_OK             = "Copie de siguranţă restaurată cu succes.";
        public static string BACKUP_RELOADED                = "Informaţiile au fost reîncărcate.";
        public static string[] RESTORE_BACKUP_ARRAY         = new [] {
         "Sunteţi sigur că doriţi să restauraţi copia de siguranţă?",
         "Restaurare copie de siguranţă"   
        };
        public static string[] ADD_MODIFY_NEW_TEST_ARRAY    = new [] {
            "Testul care încercaţi să-l salvaţi nu există. Îl adăugaţi ca şi un test nou?",
            "Adăugaţi un test nou?"
        };
        public static string[] CLOSE_APP_ARRAY              = new [] {
            "Sunteţi sigur că vreţi să închideţi aplicaţia? Orice modificări nesalvate se vor pierde.",
            "Închideţi aplicaţia?"
        };
        public static string[] SAVE_CHANGES_ARRAY = new[] {
            "Doriţi să salvaţi modificările făcute?",
            "Salvaţi modificările?"
        };
        public static string[] ADD_MODIFY_NEW_PROBLEMA_ARRAY= new []{
            "Problema nu există în listă. O adaugaţi?",
            "Adăugaţi problema?",
        };
        public static string[] LECTIE_CONTAINS_SUBNODES_ARRAY = new[]{
            "Lecţia conţine sub-noduri. Sunteţi sigur că doriţi să o ştergeţi?",
            "Ştergeţi lecţia"
        };
        public static string NO_INTREBARE_SELECTED          = "Selectaţi o întrebare înainte.";
        public static string NO_FILE_EXIST                  = "Fişier inexistent.";
        public static string NO_INTREBARI_EXIST             = "Nu există nici o întrebare adăugată. Pentru a adăuga testul trebuie să existe minim o întrebare.";

        public static string NO_UNITATE_TESTARE_SELECTED    = "Selectaţi o unitate de testare inainte.";

        public static string LECTIE_DELETED                 = "Lecţia a fost ştearsă.";
        public static string PROBLEMA_DELETED               = "Problema a fost ştearsă.";
        public static string TEST_DELETED             = "Testul a fost şters.";

        public static string INCORRECT_LECTIE_PATH          = "-- Fişierul trebuie să fie în interiorul dosarului aplicaţiei.";
        public static string INCORRECT_ID_FORMAT_LECTIE     = "Valoarea trebuie să fie numerică, nenulă si nefolosită ca ID la alta lecţie.";
        public static string INCORRECT_ID_FORMAT_PROBLEMA   = "Valoarea trebuie să fie numerică, nenulă şi nefolosită ca ID la altă problemă.";
        public static string INCORRECT_ID_FORMAT_TEST       = "Valoarea trebuie să fie numerică, nenulă şi nefolosită ca ID la alt test.";
        public static string INCORRECT_VALUE                = "Valoare incorectă.";

        public static string TITLE_UNSPECIFIED              = "Titlu nespecificat.";
        public static string TYPE_UNSPECIFIED               = "Tip nespecificat.";
        public static string VALUES_UNSPECIFIED             = "Există câmpuri necompletate.";

        public static string LECTIE_ADDED                   = "Lecţia a fost adăugată.";
        public static string PROBLEMA_ADDED                 = "Problema a fost adăugată.";
        public static string TEST_ADDED                     = "Testul a fost adăugat.";

        public static string LECTIE_SAVED                   = "Lecţia a fost salvată.";
        public static string PROBLEMA_SAVED                 = "Problema a fost salvată.";
        public static string TEST_SAVED                     = "Testul a fost salvat.";


        // Exceptions
        public static string ERROR_LOAD_SETTINGS            = "Am întâmpinat o eroare încercând să încarc setările.";
        public static string ERROR_SAVE_SETTINGS            = "Am întâmpinat o eroare încercând să salvezi setările.";
        public static string ERROR_PRINTING                 = "A fost întâmpinată o eroare în timpul imprimării.";
        public static string ERROR_CONNECT_DB               = "A fost întâmpinată o eroare în timpul conectării la baza de date.";
        public static string ERROR_SAVE_FILE                = "A fost întâmpinată o eroare în timpul salvării fişierului.";
        public static string ERROR_LOAD_LECTII              = "A fost întâmpinată o eroare în timpul încărcării lecţiilor.";
        public static string ERROR_LOAD_CODE_SNIPPETS       = "A fost întâmpinată o eroare în timpul încărcării fragmentelor de cod.";
        public static string ERROR_COMPILE                  = "A fost întâmpinată o eroare în timpul compilării.";
        public static string ERROR_SAVE_CHANGES             = "A fost întâmpinată o eroare în timpul salvării modifiărilor.";
        public static string ERROR_RESTORE_BACKUP           = "A fost întâmpinată o eroare încercând să restaurez copia de siguranţă.";
        public static string ERROR_CREATE_BACKUP            = "A fost întâmpinată o eroare încercând să creez copie de siguranţă.";
        public static string ERROR_LOAD_SOURCE_FILE         = "Am întâmpinat o eroare încercând să citesc fişierul cu codul sursă.";
        public static string ERROR_OPEN_CONTINUT_FOLDER     = "Am întâmpinat o eroare încercând să deschid dosarul cu conţinut.";
        public static string ERROR_DATABASE                 = "Am întâmpinat o eroare în baza de date.";
        public static string ERROR_SET_DATE_INTRARE         = "Am întâmpinat o eroare încercând să introduc datele de intrare.";
        public static string ERROR_GETTING_UPDATES          = "Am întâmpinat o eroare încercând să actualizez aplicaţia.";
        public static string ERROR_UPDATING                 = "Am întâmpinat o eroare în timpul actualizării.";

        #region Message Boxes
        /// <summary>
        /// Afiseaza o caseta de cu mesajul specificat. Tipul poate fi: error, info, question, warn
        /// </summary>
        /// <param name="message">Mesajul</param>
        /// <param name="caption">Titlul ferestrei</param>
        /// <param name="buttons">Butoanele afisate</param>
        /// <param name="type">Tipul mesajului - error, info, question, warn</param>
        public static DialogResult ShowMessageBox(string message, string caption, MessageBoxButtons buttons, string type)
        {
            RadMessageIcon icon;
            switch (type.ToLower())
            {
                case "error":
                    icon = RadMessageIcon.Error;
                    break;
                case "info":
                    icon = RadMessageIcon.Info;
                    break;
                case "question":
                    icon = RadMessageIcon.Question;
                    break;
                case "warn":
                    icon = RadMessageIcon.Exclamation;
                    break;
                default:
                    icon = RadMessageIcon.None;
                    break;
            }
            return RadMessageBox.Show(message, caption, buttons, icon);
        }
        /// <summary>
        /// Afiseaza o caseta de cu mesajul specificat. Tipul poate fi: error, info, question,warn
        /// </summary>
        /// <param name="message">Mesajul</param>
        public static DialogResult ShowMessageBox(string message)
        {
            return ShowMessageBox(message, " ", MessageBoxButtons.OK, "");
        }
        /// <summary>
        /// Afiseaza o caseta de cu mesajul specificat. Tipul poate fi: error, info, question, warn
        /// </summary>
        /// <param name="message">Mesajul</param>
        /// <param name="type">Tipul mesajului - error, info, question, warn</param>
        public static DialogResult ShowMessageBox(string message, string type)
        {
            return ShowMessageBox(message, " ", MessageBoxButtons.OK, type);
        }
        /// <summary>
        /// Afiseaza o caseta cu mesajul specificat. Tipul poate fi: error, info, question, warn
        /// </summary>
        /// <param name="message">Mesajul</param>
        /// <param name="caption">Titlul ferestrei</param>
        /// <param name="type">Tipul mesajului - error, info, question, warn</param>
        public static DialogResult ShowMessageBox(string message, string caption, string type)
        {
            if (type.Equals("question"))
                return new CustomMessageBox(caption,message).ShowDialog();
            return ShowMessageBox(message, caption, MessageBoxButtons.OK, type);
        }
        #endregion
    }
}