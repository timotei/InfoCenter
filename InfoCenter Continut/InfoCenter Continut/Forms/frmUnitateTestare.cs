// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using InfoCenter.Classes;
using InfoCenter.Handlers;
using InfoCenter.Util;
using Telerik.WinControls;

namespace InfoCenter.Forms
{
    public partial class FrmUnitateTestare : RadForm
    {
        /// <summary>
        /// Unitatea testare asociata formei
        /// </summary>
        public UnitateTestare UnitateTestare { get; set; }
        /// <summary>
        /// Id-ul problemei asociate
        /// </summary>
        public int IdProblema { get; set; }

        public FrmUnitateTestare(UnitateTestare unitate, int idproblema)
        {
            InitializeComponent();
            UnitateTestare = unitate;
            IdProblema = idproblema;
            SetUnitateTestareInformation();
        }

        /// <summary>
        /// Seteaza informatiile despre unitate pe forma
        /// </summary>
        public void SetUnitateTestareInformation()
        {
            if (UnitateTestare == null)
                return;

            txtNumeTest.Text = UnitateTestare.Nume;
            txtDateIesire.Text = UnitateTestare.DateIntrare;
            txtDateIntrare.Text = UnitateTestare.DateIntrare;
        }

        /// <summary>
        /// Returneaza 
        /// </summary>
        /// <returns></returns>
        private UnitateTestare GetUnitateTestare()
        {
            if (txtNumeTest.Text.Length == 0 || txtDateIesire.Text.Length == 0 || txtDateIntrare.Text.Length == 0)
            {
                Messages.ShowMessageBox(Messages.VALUES_UNSPECIFIED, "error");
                return null;
            }

            int id;
            if (UnitateTestare == null)
                id = ResourcesHandler.Instance.GetNextAvailableUnitateTestareId();
            else
                id = UnitateTestare.Id;

            return new UnitateTestare(id, IdProblema, txtNumeTest.Text, txtDateIntrare.Text, txtDateIesire.Text);
        }

        private void radButton2_Click(object sender, System.EventArgs e)
        {
            UnitateTestare = GetUnitateTestare();
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void radButton1_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}