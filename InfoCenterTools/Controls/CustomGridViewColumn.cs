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
using System.Drawing;
using Telerik.WinControls.UI;

namespace InfoCenter.Controls
{
    public class CustomGridViewTextBoxColumn<T>:GridViewTextBoxColumn where T:class
    {
        public T CustomStruct { get; set; }

        public CustomGridViewTextBoxColumn()
        {
            CustomStruct = null;
            DataType = typeof(T);
            ReadOnly = true;
        }
        public CustomGridViewTextBoxColumn(T customStruct)
        {
            CustomStruct = customStruct;
            DataType = typeof(T);
            ReadOnly = true;
        }

        public CustomGridViewTextBoxColumn(string uniqueName, string fieldName, T custromStruct)
            : base(uniqueName, fieldName)
        {
            CustomStruct = custromStruct;
            DataType = typeof(T);
            ReadOnly = true;
        }
    }
    public class CustomGridViewCommandColumn :GridViewCommandColumn
    {
        public CustomGridViewCommandColumn()
        {
            UseDefaultText = true;
            DefaultText = " ";
            DataType = typeof(Image);
            ImageLayout = System.Windows.Forms.ImageLayout.Center;
        }
        public CustomGridViewCommandColumn(string uniqueName, string fieldName)
            : base(uniqueName, fieldName)
        {
            UseDefaultText = true;
            DefaultText = " ";
            DataType = typeof(Image);
            ImageLayout = System.Windows.Forms.ImageLayout.Center;
        }
    }
}
