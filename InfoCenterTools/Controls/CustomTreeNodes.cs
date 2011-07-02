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
using System.Collections.Generic;
using InfoCenter.Classes;
using Telerik.WinControls.UI;

namespace InfoCenter.Controls
{
    /// <summary>
    /// Reprezinta un CustomTreeNode care contine un anumit tip de structura
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CustomTreeNode<T> : RadTreeNode
    {
        /// <summary>
        /// Returneaza structura care o contine nodul
        /// </summary>
        public T CustomStruct { get; set; }
        /// <summary>
        /// Returneaza adevarat daca acest nod este parinte
        /// </summary>
        public bool CustomParent { get; set; }
        /// <summary>
        /// Returneaza lista de probleme asociata nodului
        /// </summary>
        public List<Problema> ListaProbleme { get; set; }
        
        public CustomTreeNode(string text, T customStruct, bool customParent)
            : base(text)
        {
            CustomStruct = customStruct;
            CustomParent = customParent;
        }

        public CustomTreeNode(string text, IEnumerable<RadTreeNode> children, T customStruct, bool customParent)
            : this(text,customStruct,customParent)
        {
            Nodes.AddRange(children);
        }

        /// <summary>
        /// Returneaza adevarat daca acest nod este parinte
        /// </summary>
        public bool IsCustomParent
        {
            get { return CustomParent; }
        }
    }
}