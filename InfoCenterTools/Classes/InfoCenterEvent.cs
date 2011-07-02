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
    /// Tine evidenta unui eveniment
    /// </summary>
    public struct InfoCenterEvent
    {
        /// <summary>
        /// Mesajul evenimentului
        /// </summary>
        public string Message { get; set; }
        public bool Dev;

        /// <summary>
        /// Initializeaza o noua structura de eveniment
        /// </summary>
        /// <param name="message">Mesajul</param>
        /// <param name="dev">Pentru developeri</param>
        public InfoCenterEvent(string message, bool dev)
            : this()
        {
            Message = message;
            Dev = dev;
        }
    }
}
