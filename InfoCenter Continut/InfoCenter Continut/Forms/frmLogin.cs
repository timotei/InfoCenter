// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System.Windows.Forms;

namespace InfoCenter.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIntra_Click(object sender, System.EventArgs e)
        {
            lblStatus.Visible = true;

            string username = txtCont.Text;
            string password = txtParola.Text;

            if (username.Length == 0 || password.Length == 0)
            {
                lblStatus.Text = "Introduceţi informaţiile complete.";
                return;
            }

            if (username.Equals("admin") && password.Equals("pass"))
            {
                lblStatus.Text = "Informaţii de autentificare corecte.";
            }
            else
            {
                lblStatus.Text = "Informaţii de autentificare incorecte. Mai incercaţi odată.";
                return;
            }

            DialogResult = DialogResult.Yes;
            Close();
        }
    }
}