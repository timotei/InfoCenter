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
using Res = InfoCenter.Handlers.ResourcesHandler;

namespace InfoCenter
{
    partial class MainForm
    {
        /// <summary>
        /// Seteaza informatiile despre lectia selectata
        /// </summary>
        private void SetLectieInformation()
        {
            if (Res.Instance.SelectedLectie == null)
                return;

            SetDifficultyImage(lblNivelLectie, Res.Instance.SelectedLectie.Dificultate);
            btnProblemeLectie.Enabled = (Res.Instance.SelectedLectie.HasIdsProbleme);
            btnTesteLectie.Enabled = (Res.Instance.SelectedLectie.HasIdsTeste);
            AddLastAccesItem(Res.Instance.SelectedLectie);

            SelectTab(tabPageLectii.Name);
        }
    }
}