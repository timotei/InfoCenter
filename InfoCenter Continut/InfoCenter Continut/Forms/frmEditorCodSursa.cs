// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System;
using System.Windows.Forms;
using Telerik.WinControls;

namespace InfoCenter.Forms
{
    /// <summary>
    /// Editor de cod sursa
    /// </summary>
    public partial class FrmEditorCodSursa : RadForm
    {
        public FrmEditorCodSursa(string sourceCode, string highlighting)
        {
            InitializeComponent();
            textBox.SetHighlighting(highlighting);
            textBox.Text = sourceCode;
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        /// Returneaza Codul sursa scris
        /// </summary>
        /// <returns></returns>
        public string GetCurrentSourceCode()
        {
            return textBox.Text;
        }
    }
}