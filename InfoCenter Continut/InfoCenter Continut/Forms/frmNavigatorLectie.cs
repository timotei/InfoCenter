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
namespace InfoCenter.Forms
{
    /// <summary>
    /// Afiseaza o fereastra cu continutul fisierului HTML specificat
    /// </summary>
    public partial class FrmNavigatorLectie : Telerik.WinControls.RadForm
    {
        /// <summary>
        /// Arata o fereastra cu continutul fisierului specificat (HTML,HTM)
        /// </summary>
        /// <param name="fileLocation">Locatia fisierului</param>
        public FrmNavigatorLectie(string fileLocation)
        {
            InitializeComponent();
            webBrowser1.Navigate(fileLocation);
        }
    }
}