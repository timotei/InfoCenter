// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System.IO;
using System.Collections.Generic;

namespace InfoCenter.Classes
{
    /// <summary>
    /// Tipul compilatorului (CPP = C++)
    /// </summary>
    public enum CompilerType
    {
        CPP,
        NONE
    }

    /// <summary>
    /// Contine informatii despre compilator
    /// </summary>
    public class CompilerData
    {
        /// <summary>
        /// Adresa catre executabilul compilatorului
        /// </summary>
        public string FullPath { get; set; }
        /// <summary>
        /// Sablonul argumentelor care sunt folosite pentru compilare
        /// </summary>
        public string ArgumentsPattern { get; set; }

        /// <summary>
        /// Initializeaza o clasa pentru un compilator nou
        /// </summary>
        /// <param name="fullPath">Adresa catre executabil</param>
        /// <param name="argumentsPattern">Sablonul argumentelor</param>
        /// <param name="compilerType">Tipul compilatorului</param>
        public CompilerData(string fullPath, string argumentsPattern, CompilerType compilerType)
        {
            FullPath = fullPath;
            ArgumentsPattern = argumentsPattern;
            CompilerType = compilerType;
        }

        /// <summary>
        /// Returneaza directorul de lucru
        /// </summary>
        public string WorkingPath
        {
            get
            {
                return Path.GetDirectoryName(FullPath) + "\\";
            }
        }

        /// <summary>
        /// Returneaza argumentul compilatorului pe baza sablonului compilatorului
        /// </summary>
        /// <param name="parameters">Parametrii</param>
        /// <returns></returns>
        public string GetArguments(params string[] parameters)
        {
            if (parameters.Length < GetNeededNumberOfArguments())
                return "";

            return string.Format(ArgumentsPattern, parameters);
        }

        /// <summary>
        /// Returneaza tipul de compilator
        /// </summary>
        public CompilerType CompilerType
        {
            get;
            private set;
        }

        /// <summary>
        /// Returneaza numarul necesar de argumente
        /// </summary>
        /// <returns></returns>
        private int GetNeededNumberOfArguments()
        {
            char[] characters = ArgumentsPattern.ToCharArray();
            int bracketOpen=0, bracketClose=0;

            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i] == '{')
                    bracketOpen++;
                else if (characters[i] == '}')
                    bracketClose++;
            }

            if (bracketClose == bracketOpen)
                return bracketClose;

            return -1;
        }

        /// <summary>
        /// Returneaza adevarat daca exista compilatorul pe disk
        /// </summary>
        public bool HasValidPath
        {
            get
            {
                return File.Exists(FullPath);
            }
        }

        /// <summary>
        /// Returneaza extensia in functie de tipul Compilatorului
        /// </summary>
        public string SourceFileExtension
        {
            get
            {
                if (CompilerType == CompilerType.CPP)
                    return "cpp";

                return "";
            }
        }
    }
}