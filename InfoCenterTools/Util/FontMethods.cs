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
using System;
using System.Drawing;

namespace InfoCenter.Util
{
    /// <summary>
    /// Reprezinta utilitati pentru crearea si modificarea fonturilor
    /// </summary>
    public static class FontUtil
    {
        /// <summary>
        /// Creates a new font according to the parameters and returns it
        /// </summary>
        /// <param name="fontFamily">The font family</param>
        /// <param name="fontSizeString">The string that cotains the size</param>
        /// <returns></returns>
        public static Font GetFont(string fontFamily, string fontSizeString) 
        {
            if (fontFamily == null || fontFamily.Equals(string.Empty))
                fontFamily = "Arial";

            float fontSize = 10;
            if (fontSizeString != null && !fontSizeString.Equals(""))
                float.TryParse(fontSizeString, out fontSize);

            if (fontSize >= Single.MaxValue)
                fontSize = Single.MaxValue - 1;

            return new Font(fontFamily, fontSize,FontStyle.Regular);
        }
        
        /// <summary>
        /// Creates a new font according to the parameters and returns it
        /// </summary>
        /// <param name="font">The font to derive from</param>
        /// <param name="increaseSize">The number with which the font will be increased (can be negative for decreasing)</param>
        /// <returns></returns>
        public static Font GetFont(Font font, int increaseSize)
        {
            return new Font(font.FontFamily, Math.Abs(font.Size + increaseSize), FontStyle.Regular);
        }
        /// <summary>
        /// Creates a new font according to the parameters and returns it
        /// </summary>
        /// <param name="font">The font to derive from</param>
        /// <param name="fontSize">The size of the font</param>
        /// <returns></returns>
        public static Font GetFont(Font font, float fontSize)
        {
            return new Font(font.FontFamily, fontSize, FontStyle.Regular);
        }

        public static Font GetFont(Font font, float fontSize,bool bold,bool italic)
        {
            return new Font(font.FontFamily, fontSize,
             (bold ? FontStyle.Bold : FontStyle.Regular) |
             (italic ? FontStyle.Italic : FontStyle.Regular));
        }

    }
}
