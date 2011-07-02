// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace InfoCenter.Classes
{
    /// <summary>
    /// Clasa lectiei
    /// </summary>
    public class Lectie : IContinut
    {
        /// <summary>
        /// Lista de sub-lectii
        /// </summary>
        [XmlElement("lectie")]
        public List<Lectie> Lectii { get; set; }

        /// <summary>
        /// Id-ul Lectiei
        /// </summary>
        [XmlAttribute("id")]
        public int Id { get; set; }

        /// <summary>
        /// Titlul lectiei
        /// </summary>
        [XmlAttribute("title")]
        public string Titlu { get; set; }

        /// <summary>
        /// Locatia catre fisierul HTML al lectiei
        /// </summary>
        [XmlAttribute("filePath")]
        public string LocatieLectie { get; set; }
        /// <summary>
        /// Dificultatea lectiei
        /// </summary>
        [XmlAttribute("difficulty")]
        public int Dificultate { get; set; }
        /// <summary>
        /// Id-urile problemelor asociate
        /// </summary>
        [XmlAttribute("probleme")]
        public string IdsProbleme { get; set; }
        /// <summary>
        /// Id-urile testelor grila asociate
        /// </summary>
        [XmlAttribute("teste")]
        public string IdsTeste { get; set; }

        public Lectie()
        { Dificultate = 1; }

        /// <summary>
        /// Initializeaza o Lectie noua
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="title">Titlul lectiei</param>
        /// <param name="file_path">Locatia fisierului asociat lectiei</param>
        /// <param name="difficulty">Dificultatea</param>
        /// <param name="problemeIds">Sirul cu ID-urile problemelor asociate</param>
        /// <param name="testeGrilaIds">Sirul cu ID-urile testelor grila asociate</param>
        /// <param name="children">Lista de sublectii</param>
        public Lectie(int id, string title, string file_path, int difficulty, string problemeIds,
                      string testeGrilaIds, List<Lectie> children)
        {
            Id = id;
            Titlu = title;
            LocatieLectie = file_path;
            Dificultate = difficulty;
            IdsProbleme = problemeIds;
            IdsTeste = testeGrilaIds;

            Lectii = children;
        }

        /// <summary>
        /// Returneaza o valoarea booleana daca lectia are sau nu sub-lectii
        /// </summary>
        public bool HasChildren
        {
            get
            {
                if (Lectii == null)
                    return false;
                return Lectii.Count > 0;
            }
        }
        /// <summary>
        /// Returneaza o valoare booleana daca lectia are sau nu Id-uri de teste grila asociate
        /// </summary>
        public bool HasIdsTeste
        {
            get
            {
                if (IdsTeste == null)
                    return false;
                return IdsTeste.Length > 0;

            }
        }
        /// <summary>
        /// Returneaza o valoare booleana daca lectia are sau nu Id-uri de probleme asociate
        /// </summary>
        public bool HasIdsProbleme
        {
            get
            {
                if (IdsProbleme == null)
                    return false;
                return IdsProbleme.Length > 0;

            }
        }
        /// <summary>
        /// Returneaza o valoarea booleana daca lectia are asociata sau nu un fisier, si acesta se poate deschide
        /// </summary>
        public bool IsBrowsable
        {
            get
            {
                if (LocatieLectie == null)
                    return false;
                return LocatieLectie.Length > 0;
            }
        }

        public override string ToString()
        {
            return string.Format("[Lectie] - Id:{0},Titlu:{1}", Id, Titlu);
        }

        /// <summary>
        /// Returneaza tipul intr-un format scrut
        /// </summary>
        /// <returns></returns>
        public string GetShortType()
        {
            return "lectie";
        }
    }

    /// <summary>
    /// Tine evidenta lectiilor din program
    /// </summary>
    [XmlRoot("lectii_content")]
    [Serializable]
    public class LectiiHolder
    {
        private int _count;

        public LectiiHolder()
        {
            Lectii = new List<Lectie>();
        }

        [XmlElement("lectie")]
        public List<Lectie> Lectii { get; set; }

        /// <summary>
        /// Returneaza numarul total de lectii, include si sublectiile
        /// </summary>
        public int Count
        {
            get
            {
                _count = 0;
                GetCount(Lectii);
                return _count;
            }
        }
        /// <summary>
        /// Sterge toate lectiile din lista
        /// </summary>
        public void Clear()
        {
            if (Lectii == null)
            {
                Lectii = new List<Lectie>();
                return;
            }

            Lectii.Clear();
        }
        /// <summary>
        /// Numara lectiile totale incluzand si sublectiile
        /// </summary>
        /// <param name="lista">Lista pentru care se face numaratoarea</param>
        private void GetCount(List<Lectie> lista)
        {
            _count += lista.Count;
            foreach (Lectie lectie in lista)
            {
                GetCount(lectie.Lectii);
            }
        }
    }
}