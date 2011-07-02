using Telerik.WinControls;
using System.Windows.Forms;

namespace InfoCenter.Controls
{
    public sealed partial class CustomMessageBox : RadForm
    {
        /// <summary>
        /// Initializeaza un nou msg box cu informatiile specificate
        /// </summary>
        /// <param name="title">Titlul mesajului</param>
        /// <param name="message">Mesajul</param>
        public CustomMessageBox(string title,string message)
        {
            InitializeComponent();
            MaximumSize = new System.Drawing.Size((int)(SystemInformation.WorkingArea.Width*0.60),
                (int)(SystemInformation.WorkingArea.Height*0.90));
            lblText.MaximumSize = MaximumSize;
            Text = "        " + title;
            lblText.Text = message;
        }

        private void btnNu_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void btnDa_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }
    }
}
