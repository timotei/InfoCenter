// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System;
using System.Drawing;
using System.Windows.Forms;

namespace InfoCenter.Forms
{
    public partial class FrmAfisareMarita : Telerik.WinControls.RadForm
    {
        /// <summary>
        /// Afiseaza o noua forma cu textul si titlul specificate
        /// </summary>
        /// <param name="title">Titlul formei</param>
        /// <param name="highlighting">Tipul de highlighting folosit</param>
        public FrmAfisareMarita(string title, string highlighting)
        {
            InitializeComponent();
            Text = "Afişare - " + title;
            textBox.SourceTextBox.Font = new Font("Courier New", 16);
            textBox.SourceTextBox.SetHighlighting(highlighting);
            textBox.SourceTextBox.ActiveTextAreaControl.TextArea.Document.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Seteaza textul in textbox
        /// </summary>
        /// <param name="text">Textul afisat</param>
        public void SetText(string text)
        {
            textBox.Text = text;
        }

        private void schimbaFontToolStripMenuIte_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                textBox.Font = fontDialog1.Font;
        }
    }
}