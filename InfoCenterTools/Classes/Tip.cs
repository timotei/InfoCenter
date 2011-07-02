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
    /// Reprezinta tipul unui continut
    /// </summary>
    public class Tip
    {
        /// <summary>
        /// Id-ul tipului
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// Numele tipului
        /// </summary>
        public string Nume { get; set; }

        /// <summary>
        /// Initializeaza un tip nou
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="nume">Numele tipului</param>
        public Tip(int id, string nume)
        {
            Id = id;
            Nume = nume;
        }

        public override string ToString()
        {
            return string.Format("[Tip] - Id:{0},Nume:{1}", Id, Nume);
        }
    }
}
