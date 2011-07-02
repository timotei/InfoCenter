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
using System.Windows.Forms;

namespace InfoCenter.Controls
{
    /// <summary>
    /// Creaza un ListViewItem pe baza tipului specificat
    /// </summary>
    /// <typeparam name="T">Tipul structuri care o va contine acest ListViewItem</typeparam>
    public class CustomListViewItem<T> : ListViewItem
    {
        /// <summary>
        /// Structura custom asignata ListViewItem-ului
        /// </summary>
        public T CustomStruct { get; set; }

        public CustomListViewItem(string text, T customStruct)
            : base(text)
        {
            CustomStruct = customStruct;
        }

        public CustomListViewItem(string text, T customStruct, ListViewGroup group)
            : base(text,group)
        {
            CustomStruct = customStruct;
        }

        public CustomListViewItem(string[] text, T customStruct)
            : base(text)
        {
            CustomStruct = customStruct;
        }
    }
}
