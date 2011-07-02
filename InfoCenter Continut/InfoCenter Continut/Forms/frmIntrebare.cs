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
using InfoCenter.Classes;
using Telerik.WinControls;

namespace InfoCenter.Forms
{
    public abstract class FrmIntrebare : RadForm
    {
        /// <summary>
        /// Intrebarea asociata formei
        /// </summary>
        public abstract IntrebareTest Intrebare { get; set; }
        /// <summary>
        /// Id-ul testului caruia ii este asociata intrebarea
        /// </summary>
        public abstract int IdTest { get; set; }
        /// <summary>
        /// Seteaza informatiile intrebarii pe forma
        /// </summary>
        public abstract void SetIntrebareInformation();
    }
}