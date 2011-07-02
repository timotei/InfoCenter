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
using InfoCenter.Controls;
using System.Collections.Generic;

namespace InfoCenter.Handlers
{
    /// <summary>
    /// Tine evidenta testului curent si lista testelor facute
    /// </summary>
    public sealed class TestHandler
    {
        #region Singleton
        private static TestHandler _Instance = new TestHandler();
        private TestHandler()
        {
            ListaIntrebari = new List<TestGroupBox>();
        }
        public static TestHandler Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new TestHandler();
                return _Instance;
            }
        }
        #endregion

        /// <summary>
        /// Punctajul din oficiu acordat 
        /// </summary>
        public float PunctajOficiu { get; set; }

        /// <summary>
        /// Punctajul obtinut la ultimul test (fara puncte din oficiu)
        /// </summary>
        public float Punctaj { get; set; }

        /// <summary>
        /// Punctajul maxim care se poate lua, raspunzand corect la toate intrebarile (fara puncte din oficiu)
        /// </summary>
        public float PunctajMaxim { get; set; }
                
        /// <summary>
        /// Lista curenta de intrebari (de tip TestGroupBox)
        /// </summary>
        public List<TestGroupBox> ListaIntrebari
        {
            get; private set;
        }

        /// <summary>
        /// Numarul de ordine al intrebari curente din ListaIntrebari
        /// </summary>
        public int IntrebareCurenta;
        /// <summary>
        /// Returneaza o valoare de adevar daca utilizatorul a terminat vreun test.
        /// </summary>
        public bool FinishedTest;
    }
}