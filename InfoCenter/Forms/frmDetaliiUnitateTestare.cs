// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System.Windows.Forms;
using InfoCenter.Classes;
using InfoCenter.Handlers;

namespace InfoCenter.Forms
{
    public partial class FrmDetaliiUnitateTestare : Form
    {
        /// <summary>
        /// Unitatea testare asociata controlului
        /// </summary>
        public UnitateTestare UnitateTestare { get; set; }

        public FrmDetaliiUnitateTestare(UnitateTestare unitate)
        {
            InitializeComponent();
            UnitateTestare = unitate;
            SetUnitateInformation();
        }

        /// <summary>
        /// Se seteaza informatiile despre unitate pe forma
        /// </summary>
        private void SetUnitateInformation()
        {
            if (UnitateTestare == null)
            {
                lblCreeaza.Visible = true;
                txtNumeUnitate.Visible = true;
                txtDateIesire.ReadOnly = false;
                txtDateIntrare.ReadOnly = false;

                // ascund partea cu datele utilizatorului
                Size = new System.Drawing.Size(318, 185);
                return;
            }

            lblNume.Text = UnitateTestare.Nume;
            txtDateIesire.Text = UnitateTestare.DateIesire;
            txtDateIntrare.Text = UnitateTestare.DateIntrare;
            txtDateUtilizator.Text = UnitateTestare.DateUtilizator;
        }

        private void lblInchide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void lblCreeaza_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtNumeUnitate.Text.Length == 0 || txtDateIntrare.Text.Length == 0 ||
                txtDateIesire.Text.Length == 0)
            {
                return;
            }

            UnitateTestare = new UnitateTestare(ResourcesHandler.Instance.GetNextAvailableUnitateTestareId(),
                0, txtNumeUnitate.Text, txtDateIntrare.Text, txtDateIesire.Text);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}