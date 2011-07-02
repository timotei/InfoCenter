// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System.Collections.Generic;

namespace InfoCenter.Classes
{
    /// <summary>
    /// Clasa de baza a unui test
    /// </summary>
    public sealed class Test : IContinut
    {
        /// <summary>
        /// Id-ul testului
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// Titlul testului
        /// </summary>
        public string Titlu { get; set; }
        /// <summary>
        /// Tipul testului
        /// </summary>
        public string Tip { get; set; }
        /// <summary>
        /// Dificultatea testului
        /// </summary>
        public int Dificultate { get; set; }
        /// <summary>
        /// Punctaj din oficiu
        /// </summary>
        public float PunctajOficiu { get; set; }
        /// <summary>
        /// Punctajul maxim care se poate lua, raspunzand corect la toate intrebarile(fara puncte din oficiu)
        /// </summary>
        public float PunctajMaxim
        {
            get
            {
                float tempPunctaj = 0;
                foreach (var intrebare in Intrebari)
                    tempPunctaj += intrebare.Puncte;
                return tempPunctaj;
            }
        }
        /// <summary>
        /// Intrebarile testului
        /// </summary>
        public List<IntrebareTest> Intrebari { get; set; }

        /// <summary>
        /// Initializeaza un Test Grila
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="title">Titlul testului</param>
        /// <param name="type">Tipul testului</param>
        /// <param name="difficulty">Dificultatea testului</param>
        /// <param name="punctajOficiu">Punctajul din oficiu</param>
        /// <param name="intrebari">Lista de intrebari asociate testului</param>
        public Test(int id, string title, string type, int difficulty, float punctajOficiu,
                    List<IntrebareTest> intrebari)
        {
            Titlu = title;
            Id = id;
            Tip = type;
            Dificultate = difficulty;
            PunctajOficiu = punctajOficiu;
            Intrebari = intrebari ?? new List<IntrebareTest>();
        }

        public override string ToString()
        {
            return string.Format("[Test] - Id:{0},Titlu:{1},Tip:{2},Dificultate:{3},Punctaj:{4},Nr Intrebari:{5}",
                                 Id, Titlu, Tip, Dificultate, PunctajOficiu, Intrebari.Count);
        }
        /// <summary>
        /// Returneaza titlul titlului
        /// </summary>
        /// <returns></returns>
        public string GetTitlu()
        {
            return Titlu;
        }
        /// <summary>
        /// Returneaza id-ul testului
        /// </summary>
        /// <returns></returns>
        public int GetId()
        {
            return Id;
        }

        /// <summary>
        /// Returneaza tipul intr-un format scrut
        /// </summary>
        /// <returns></returns>
        public string GetShortType()
        {
            return "test";
        }
    }

    /// <summary>
    /// Clasa de baza a unei intrebari
    /// </summary>
    public class IntrebareTest
    {
        /// <summary>
        /// Id-ul intrebarii
        /// </summary>
        public int Id;
        /// <summary>
        /// Id-ul testului grila de care apartine
        /// </summary>
        public int IdTest;
        /// <summary>
        /// Intreabarea
        /// </summary>
        public string Intrebare;
        /// <summary>
        /// Puncte acordate pentru raspuns corect
        /// </summary>
        public float Puncte;
        /// <summary>
        /// Raspunsul corect
        /// </summary>
        public string RaspunsCorect;

        /// <summary>
        /// Initializeaza o intrebare de tip grila
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="idTest">Id-ul testului de care apartine</param>
        /// <param name="intrebare">Textul intrebarii</param>
        /// <param name="raspunsCorect">Raspunsul Corect</param>
        /// <param name="puncte">Punctele obtinute cand utilizatorul raspunde corect</param>
        public IntrebareTest(int id, int idTest, string intrebare, string raspunsCorect, float puncte)
        {
            Id = id;
            IdTest = idTest;
            Intrebare = intrebare;
            Puncte = puncte;
            RaspunsCorect = raspunsCorect;
        }
        public override string ToString()
        {
            return Intrebare;
        }
    }

    /// <summary>
    /// Clasa intrebarii testului grila
    /// </summary>
    public sealed class IntrebareGrila : IntrebareTest
    {
        /// <summary>
        /// Raspunsul 1
        /// </summary>
        public string Raspuns1;
        /// <summary>
        /// Raspunsul 2
        /// </summary>
        public string Raspuns2;
        /// <summary>
        /// Raspunsul 3
        /// </summary>
        public string Raspuns3;
        /// <summary>
        /// Raspunsul 4
        /// </summary>
        public string Raspuns4;
        /// <summary>
        /// Raspunsul corect (intre 1-4)
        /// </summary>
        public new int RaspunsCorect;

        /// <summary>
        /// Initializeaza o intrebare de tip grila
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="idTest">Id-ul testului de care apartine</param>
        /// <param name="intrebare">Textul intrebarii</param>
        /// <param name="raspunsCorect">Raspunsul Corect</param>
        /// <param name="raspuns1">Raspuns 1</param>
        /// <param name="raspuns2">Raspuns 2</param>
        /// <param name="raspuns3">Raspuns 3</param>
        /// <param name="raspuns4">Raspuns 4</param>
        /// <param name="puncte">Punctele acordate in cazul ca utilizatorul a raspuns corect</param>
        public IntrebareGrila(int id, int idTest, string intrebare, int raspunsCorect, string raspuns1,
                              string raspuns2, string raspuns3, string raspuns4, float puncte)
            : base(id, idTest, intrebare, raspunsCorect.ToString(), puncte)
        {
            Raspuns1 = raspuns1;
            Raspuns2 = raspuns2;
            Raspuns3 = raspuns3;
            Raspuns4 = raspuns4;
            RaspunsCorect = raspunsCorect;
        }

        public string ToLongString()
        {
            return string.Format("[IntrebareGrila] - Id:{0},IdTest:{1},Intrebare{2}",
                                 Id, IdTest, Intrebare.Substring(0, 5));
        }

        public override string ToString()
        {
            return Intrebare;
        }
    }
}