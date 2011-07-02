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
using InfoCenter.Handlers;
using InfoCenter.Util;

namespace InfoCenter
{
    partial class MainForm
    {
        /// <summary>
        /// Salveaza setarile de pe forma si apoi salveaza pe disc
        /// </summary>
        private void SaveChanges()
        {
            ContinutHandler.Instance.LectiiContinut = treeViewLectii.Nodes;
            if (ContinutHandler.Instance.SaveChanges())
                Messages.ShowMessageBox(Messages.INFORMATION_SAVED, "info");
        }
        /// <summary>
        /// Creeaza copii de siguranta pe disc
        /// </summary>
        private void MakeBackup()
        {
            SaveChanges();
            ContinutHandler.Instance.BackupAll();
        }
        /// <summary>
        /// Restaureaza copiile de siguranta de pe disc
        /// </summary>
        private void RestoreBackup()
        {
            if (Messages.ShowMessageBox(Messages.RESTORE_BACKUP_ARRAY[0],
                  Messages.RESTORE_BACKUP_ARRAY[1], "question") == DialogResult.Yes)
            {
                ContinutHandler.Instance.RestoreAll(false);
                LoadingFinished();
            }
        }
    }
}