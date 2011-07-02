// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
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