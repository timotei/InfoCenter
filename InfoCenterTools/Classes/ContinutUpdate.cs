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
    /// Tipul de update al continutului
    /// </summary>
    public enum ContinutUpdateType { ADD, DELETE, MODIFY, NONE }

    /// <summary>
    /// Contine informatie legata update
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ContinutUpdate<T>
    {
        /// <summary>
        /// Structura custom asociata update-ului
        /// </summary>
        public T CustomStruct { get; set; }
        /// <summary>
        /// Tipul update-ului
        /// </summary>
        public ContinutUpdateType UpdateType { get; set; }

        public ContinutUpdate(T customStruct, ContinutUpdateType type)
        {
            CustomStruct = customStruct;
            UpdateType = type;
        }

        public override string ToString()
        {
            return string.Format("{0} - UpdateType:{1}", CustomStruct.GetType(), UpdateType);
        }
    }
}