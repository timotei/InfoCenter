// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk

namespace InfoCenter.Forms
{
    /// <summary>
    /// Afiseaza o fereastra cu continutul fisierului HTML specificat
    /// </summary>
    public partial class FrmNavigatorLectie : Telerik.WinControls.RadForm
    {
        /// <summary>
        /// Arata o fereastra cu continutul fisierului specificat (HTML,HTM)
        /// </summary>
        /// <param name="fileLocation">Locatia fisierului</param>
        public FrmNavigatorLectie(string fileLocation)
        {
            InitializeComponent();
            webBrowser1.Navigate(fileLocation);
        }
    }
}