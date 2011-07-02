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
using System.IO;

namespace InfoCenter.Classes
{
    public class Problema : IContinut
    {
        /// <summary>
        /// Initializeaza o Problema noua
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="type">Tipul problemei</param>
        /// <param name="title">Titlul problemei</param>
        /// <param name="requirement">Cerinta problemei</param>
        /// <param name="difficulty">Dificultatea problemei</param>
        /// <param name="cuvinteCheie">Cuvintele cheie asociate problemei</param>
        /// <param name="locatieFolder">Locatia pentru fisierele sursa</param>
        public Problema(int id, string type, string title, string requirement,
                        int difficulty, string cuvinteCheie, string locatieFolder)
        {
            Id = id;
            Tip = type;
            Titlu = title;
            Cerinta = requirement;
            Dificultate = difficulty;
            CuvinteCheie = cuvinteCheie;
            LocatieFolder = locatieFolder;
        }
        /// <summary>
        /// Locatia folderului unde se afla codul sursa
        /// </summary>
        public string LocatieFolder { get; set; }
        /// <summary>
        /// ID-ul problemei
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Tipul problemei
        /// </summary>
        public string Tip { get; set; }
        /// <summary>
        /// Titlul problemei
        /// </summary>
        public string Titlu { get; set; }
        /// <summary>
        /// Cerinta problemei
        /// </summary>
        public string Cerinta { get; set; }
        /// <summary>
        /// Dificultatea problemei
        /// </summary>
        public int Dificultate { get; set; }
        /// <summary>
        /// Cuvintele Cheie asociate problemei
        /// </summary>
        public string CuvinteCheie { get; set; }
        /// <summary>
        /// Returneaza locatia codului sursa C++
        /// </summary>
        public string LocatieCPP
        {
            get { return LocatieFolder + Id + ".cpp"; }
        }
        /// <summary>
        /// Returneaza o valoarea booleana daca are sau nu codul sursa in C++
        /// </summary>
        public bool HasCPPSource
        {
            get { return File.Exists(LocatieCPP); }
        }
        public override string ToString()
        {
            return string.Format("[Problema] - Id:{0},Tip:{1},Titlu:{2},Dificultate:{3},CuvinteCheie:{4},Folder:{5}",
                                 Id, Tip, Titlu, Dificultate, CuvinteCheie, LocatieFolder);
        }

        /// <summary>
        /// Returneaza tipul intr-un format scrut
        /// </summary>
        /// <returns></returns>
        public string GetShortType()
        {
            return "problema";
        }
    }

    /// <summary>
    /// Reprezinta un sir de cuvinte cheie care poate fi atasat problemelor
    /// </summary>
    public class CuvantCheie
    {
        /// <summary>
        /// Id-ul cuvantului cheie
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// Sirul de cuvinte cheie separate prin virgula
        /// </summary>
        public string Cuvinte { get; set; }

        /// <summary>
        /// Initializeaza un CuvantCheie nou
        /// </summary>
        /// <param name="id">Id-ul</param>
        /// <param name="cuvinte">Cuvintele cheie</param>
        public CuvantCheie(int id, string cuvinte)
        {
            Id = id;
            Cuvinte = cuvinte;
        }
    }
}