// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
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