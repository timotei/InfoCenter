using System.Collections.Generic;
using System.Drawing;
using InfoCenter.Classes;
using InfoCenter.Controls;
using InfoCenter.Extensions;
using InfoCenter.Util;

namespace InfoCenter.Forms
{
    /// <summary>
    /// Selecteaza probleme pentru a le asocia cu o lectie
    /// </summary>
    public partial class FrmSelectareProblema : Telerik.WinControls.RadForm
    {
        public FrmSelectareProblema()
        {
            InitializeComponent();
            listaProbleme.Groups.AddRange(Handlers.ResourcesHandler.Instance.ListaTipuri.ToListViewGroupArray());
            FillList();
            txtProbleme.Text = Handlers.ResourcesHandler.Instance.SelectedProblemeIds;
            foreach (CustomListViewItem<Problema> item in listaProbleme.Items)
                if (item != null && item.CustomStruct != null)
                    if (txtProbleme.Text.Split(',').EqualsTo(item.CustomStruct.Id.ToString()))
                        item.BackColor = Color.Yellow;
        }
        #region Form methods

        private void btnAdauga_Click(object sender, System.EventArgs e)
        {
            if (listaProbleme.SelectedItems.Count == 0)
                return;
            CustomListViewItem<Problema> item = (CustomListViewItem<Problema>)listaProbleme.SelectedItems[0];

            if (item.CustomStruct == null)
                return;

            if (txtProbleme.Text.Contains(item.CustomStruct.Id.ToString()))
            {
                Messages.ShowMessageBox(Messages.PROBLEMA_ALREADY_ADDED, "info");
                return;
            }

            if (txtProbleme.Text.Trim().Length != 0)
                txtProbleme.Text += ",";
            txtProbleme.Text += item.CustomStruct.Id.ToString();
            listaProbleme.Items[listaProbleme.SelectedIndices[0]].BackColor = Color.Yellow;
            ValidateIds();
        }

        private void btnSterge_Click(object sender, System.EventArgs e)
        {
            if (listaProbleme.SelectedItems.Count == 0)
                return;
            CustomListViewItem<Problema> item = (CustomListViewItem<Problema>)listaProbleme.SelectedItems[0];

            if (item.CustomStruct == null)
                return;
            txtProbleme.Text = txtProbleme.Text.Replace(item.CustomStruct.Id.ToString(), "");
            listaProbleme.Items[listaProbleme.SelectedIndices[0]].BackColor = Color.White;
            ValidateIds();
        }

        private void btnSalveaza_Click(object sender, System.EventArgs e)
        {
            ValidateIds();
            Handlers.ResourcesHandler.Instance.SelectedProblemeIds = txtProbleme.Text;
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void txtProbleme_TextChanged(object sender, System.EventArgs e)
        {
            List<char> allowedChars = new List<char>();
            allowedChars.AddRange(new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ',' });
            for (int i = 0; i < txtProbleme.Text.Length; i++)
                if (!allowedChars.Contains(txtProbleme.Text[i]))
                    txtProbleme.Text = txtProbleme.Text.Remove(i, 1);
            txtProbleme.Text = txtProbleme.Text.Replace(",0,", "");
            txtProbleme.Text = txtProbleme.Text.Replace(",0", "");
            if (txtProbleme.Text.StartsWith("0"))
                txtProbleme.Text = txtProbleme.Text.Substring(1);
        }

        private void listaProbleme_DoubleClick(object sender, System.EventArgs e)
        {
            if (listaProbleme.SelectedIndices.Count != 1)
                return;
            if (listaProbleme.SelectedItems[0].BackColor == Color.Yellow)
                btnSterge.PerformClick();
            else
                btnAdauga.PerformClick();
        }

        private void btnInchide_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        #endregion
        #region Custom methods
        /// <summary>
        /// Umple lista cu probleme
        /// </summary>
        public void FillList()
        {
            listaProbleme.Items.Clear();
            foreach (Problema problema in Handlers.ResourcesHandler.Instance.ListaProbleme)
            {
                listaProbleme.Items.Add(new CustomListViewItem<Problema>(problema.Titlu, problema,
                    listaProbleme.Groups[problema.Tip]));
            }
        }
        /// <summary>
        /// Valideaza ID-urile selectate
        /// </summary>
        private void ValidateIds()
        {
            if (txtProbleme.Text.Length == 0)
                return;

            while (txtProbleme.Text.StartsWith(","))
                txtProbleme.Text = txtProbleme.Text.Substring(1);
            while (txtProbleme.Text.EndsWith(","))
                txtProbleme.Text = txtProbleme.Text.Substring(0, txtProbleme.Text.Length - 1);
            txtProbleme.Text = txtProbleme.Text.Replace(" ", "");
            while (txtProbleme.Text.Contains(",,"))
                txtProbleme.Text = txtProbleme.Text.Replace(",,", ",");
        }
        #endregion
    }
}