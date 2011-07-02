// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System.Windows.Forms;

namespace InfoCenter.Forms
{
    public partial class FrmSplash : Form
    {
        public FrmSplash(System.Drawing.Icon icon, System.Drawing.Image backgroundImage)
        {
            InitializeComponent();
            Icon = icon;
            BackgroundImage = backgroundImage;
            Activate();
        }

        /// <summary>
        /// Seteaza status-ul pe forma
        /// </summary>
        /// <param name="newStatus">noul status</param>
        public void SetStatus(string newStatus)
        {
            statusLabel.Text = newStatus;
        }

    }
}