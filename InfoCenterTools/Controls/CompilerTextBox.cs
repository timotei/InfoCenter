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
// TextEditorControl: http://icsharpcode.net
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using InfoCenter.Classes;
using InfoCenter.Extensions;
using System.Text.RegularExpressions;

namespace InfoCenter.Controls
{
    /// <summary>
    /// TextBox cu syntax highlighting si line numbering
    /// </summary>
    public partial class CompilerTextBox : UserControl
    {
        /// <summary>
        /// C++ Keywords
        /// </summary>
        private readonly string[] _cppMarkers = new [] { "#","#include","main(",};

        /// <summary>
        /// Markere pentru citire din consola
        /// </summary>
        private readonly string[] _consoleInMarkers = new[] { "cin"};
        /// <summary>
        /// Markere pentru afisare in consola
        /// </summary>
        private readonly string[] _consoleOutMarkers = new[] { "cout" };

        // Regex date intrare: ".+\.in" | fixed: [^\"]+\.in
        // Regex date iesire : ".+\.out" | fixed: [^\"]+\.in

        public CompilerTextBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Returneaza Controlul de tip TextEditor care contine codul sursa
        /// </summary>
        public ICSharpCode.TextEditor.TextEditorControl SourceTextBox
        {
            get
            {
                return txtSource;
            }
        }

        /// <summary>
        /// Returneaza sau seteaza textul scris in SourceTextBox
        /// </summary>
        public override string Text
        {
            get
            {
                return txtSource.Text;
            }
            set
            {
                if (value == null)
                    value = "";
                txtSource.Text = value;
            }
        }

        /// <summary>
        /// Returneaza sau seteaza fontul SourceTextBox-ului
        /// </summary>
        public override Font Font
        {
            get
            {
                return txtSource.Font;
            }
            set
            {
                if (value == null)
                    return;
                txtSource.Font = value;
            }
        }

        /// <summary>
        /// Returneaza tipul compilatorului folosit in codul sursa existent, pe baza cuvintelor cheie
        /// </summary>
        /// <returns></returns>
        public CompilerType GetCompilerType()
        {
            foreach (string str in _cppMarkers)
                if (txtSource.Text.Contains(str))
                    return CompilerType.CPP;

            return CompilerType.NONE;
        }

        /// <summary>
        /// Returneaza lista fisierelor unde se vor scrie datele de iesire
        /// </summary>
        /// <returns></returns>
        public List<string> GetDateIesireFiles()
        {
            return GetFilesInOutMatches(@"[^\""]+\.out");
        }


        /// <summary>
        /// Returneaza lista fisierelor unde se vor scrie datele de intrare
        /// </summary>
        /// <returns></returns>
        public List<string> GetDateIntrareFiles()
        {
            return GetFilesInOutMatches(@"[^\""]+\.in");
        }

        /// <summary>
        /// Returneaza lista fisierelor gasite dupa un anumit regex
        /// </summary>
        /// <param name="regex">Regex-ul dupa care se face cautarea</param>
        /// <returns></returns>
        private List<string> GetFilesInOutMatches(string regex)
        {
            var newList = new List<string>();
            MatchCollection matches = Regex.Matches(txtSource.Text, regex,
                RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);
            foreach (Match match in matches)
            {
                //  punctul
                newList.Add(match.Value.Replace(".", ""));
            }
            return newList;
        }

        /// <summary>
        /// Returneaza adevarat daca se foloseste console in in aplicatia utilizatorului
        /// </summary>
        /// <returns></returns>
        public bool HasConsoleIn()
        {
            return (Text.Contains(_consoleInMarkers));
        }

        /// <summary>
        /// Returneaza adevarat daca se foloseste console out in aplicatia utilizatorului
        /// </summary>
        /// <returns></returns>
        public bool HasConsoleOut()
        {
            return (Text.Contains(_consoleOutMarkers));
        }
    }
}
