// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
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