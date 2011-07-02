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

namespace InfoCenter.Classes
{
    /// <summary>
    /// Interfata tipului de continut din InfoCenter
    /// </summary>
    public interface IContinut
    {
        string Titlu { get; set; }
        int Id { get; }
    }
}
