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

namespace InfoCenter.Controls
{
    public interface ITestGroupBox
    {
        void SetIntrebareNr(int nr);
        bool ValidateRaspuns(bool markOnForm);
        void SetControlsState(bool state);
        int NrCrt
        {
            get;
            set;
        }
        string Raspuns
        {
            get;
        }
        IntrebareTest Intrebare
        {
            get;
            set;
        }
    }
}
