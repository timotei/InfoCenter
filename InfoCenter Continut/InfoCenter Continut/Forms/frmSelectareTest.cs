// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System;
using System.Drawing;
using InfoCenter.Classes;
using InfoCenter.Controls;
using InfoCenter.Handlers;
using InfoCenter.Util;

namespace InfoCenter.Forms
{
    /// <summary>
    /// Selecteaza teste pentru a le asocia cu o lectie
    /// </summary>
    public partial class FrmSelectareTest : Telerik.WinControls.RadForm
    {
        public FrmSelectareTest()
        {
            InitializeComponent();
            FillTeste();
            txtTeste.Text = ResourcesHandler.Instance.SelectedTesteIds;
            foreach (var parentNode in treeViewTeste.Nodes)
                foreach (CustomTreeNode<Test> item in parentNode.Nodes)
                    if (item != null && item.CustomStruct != null)
                        if (txtTeste.Text.Contains(item.CustomStruct.Id.ToString()))
                            item.BackColor = Color.Yellow;
        }
        #region Custom methods
        /// <summary>
        /// Umple lista cu teste
        /// </summary>
        private void FillTeste()
        {
            treeViewTeste.Nodes.Clear();
            treeViewTeste.Nodes.AddRange(ResourcesHandler.Instance.GetTesteTreeNodes());
        }
        /// <summary>
        /// Valideaza id-urile introduse
        /// </summary>
        private void ValidateIds()
        {
            if (txtTeste.Text.Length == 0)
                return;

            while (txtTeste.Text.StartsWith(","))
                txtTeste.Text = txtTeste.Text.Substring(1);
            while (txtTeste.Text.EndsWith(","))
                txtTeste.Text = txtTeste.Text.Substring(0, txtTeste.Text.Length - 1);
            txtTeste.Text = txtTeste.Text.Replace(" ", "");
            while (txtTeste.Text.Contains(",,"))
                txtTeste.Text = txtTeste.Text.Replace(",,", ",");
        }
        #endregion
        #region Form methods
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (treeViewTeste.SelectedNode == null)
                return;
            CustomTreeNode<Test> item = (CustomTreeNode<Test>)treeViewTeste.SelectedNode;

            if (item.CustomStruct == null)
                return;
            if (txtTeste.Text.Contains(item.CustomStruct.Id.ToString()))
            {
                Messages.ShowMessageBox(Messages.TEST_ALREADY_ADDED, "info");
                return;
            }
            if (txtTeste.Text.Trim().Length != 0)
                txtTeste.Text += ",";
            txtTeste.Text += item.CustomStruct.Id.ToString();
            treeViewTeste.SelectedNode.BackColor = Color.Yellow;
            ValidateIds();

        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (treeViewTeste.SelectedNode == null)
                return;
            CustomTreeNode<Test> item = (CustomTreeNode<Test>)treeViewTeste.SelectedNode;

            if (item.CustomStruct == null)
                return;
            txtTeste.Text = txtTeste.Text.Replace(item.CustomStruct.Id.ToString(), "");
            treeViewTeste.SelectedNode.BackColor = Color.Transparent;
            ValidateIds();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ValidateIds();
            ResourcesHandler.Instance.SelectedTesteIds = txtTeste.Text;
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void treeViewTeste_DoubleClick(object sender, EventArgs e)
        {
            if (treeViewTeste.SelectedNode == null)
                return;
            if (treeViewTeste.SelectedNode.BackColor == Color.Yellow)
                btnSterge.PerformClick();
            else
                btnAdauga.PerformClick();
        }

        private void btnInchide_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}