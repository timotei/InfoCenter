// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System.Collections.Generic;
using InfoCenter.Classes;
using InfoCenter.Handlers;
using InfoCenter.Util;
using Telerik.WinControls;
using InfoCenter.Controls;

namespace InfoCenter.Forms
{
    /// <summary>
    /// Administreaza tipurile existente
    /// </summary>
    public partial class FrmAdministrareTipuri : RadForm
    {
        /// <summary>
        /// Tipul selectat
        /// </summary>
        private Tip _selectedTip;
        /// <summary>
        /// Lista temporara de modificari
        /// </summary>
        private List<ContinutUpdate<Tip>> tempList = new List<ContinutUpdate<Tip>>();

        public FrmAdministrareTipuri()
        {
            InitializeComponent();
        }
        #region Form methods
        private void btnAdauga_Click(object sender, System.EventArgs e)
        {
            AdaugaTip();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            SaveTip();
        }

        private void btnTipNou_Click(object sender, System.EventArgs e)
        {
            TipNou();
        }

        private void btnSterge_Click(object sender, System.EventArgs e)
        {
            StergeTip();
        }

        private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
                return;
            _selectedTip = ((CustomListViewItem<Tip>)listView1.SelectedItems[0]).CustomStruct;
            SetTipInformation();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        private void btnSaveClose_Click(object sender, System.EventArgs e)
        {
            SaveChanges();
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void frmAdministrareTipuri_Load(object sender, System.EventArgs e)
        {
            foreach (Tip tip in ResourcesHandler.Instance.ListaTipuri)
            {
                listView1.Items.Add(new CustomListViewItem<Tip>(tip.Nume, tip));
            }
        }
        #endregion
        #region Custom Methods
        /// <summary>
        /// Sterge tipul selectat
        /// </summary>
        private void StergeTip()
        {
            if (listView1.SelectedItems.Count != 1)
                return;
            listView1.Items.Remove(listView1.SelectedItems[0]);

            tempList.Add(new ContinutUpdate<Tip>(_selectedTip, ContinutUpdateType.DELETE));
            _selectedTip = null;
        }
        /// <summary>
        /// Reseteaza campurile pentru a adauga un nou tip
        /// </summary>
        private void TipNou()
        {
            _selectedTip = null;
            txtNume.Text = "";
        }
        /// <summary>
        /// Returneaza tipul de pe forma, in functie de datele introduse
        /// </summary>
        /// <returns></returns>
        private CustomListViewItem<Tip> GetTip()
        {
            if (txtNume.Text == "")
            {
                Messages.ShowMessageBox("Nu aţi specificat un nume pentru tip.", "info");
                return null;
            }
            return new CustomListViewItem<Tip>(txtNume.Text, new Tip(ResourcesHandler.Instance.GetNextAvailableTipId(),
                txtNume.Text));
        }
        /// <summary>
        /// Salveaza modificarile facute tipului
        /// </summary>
        private void SaveTip()
        {
            var newItem = GetTip();
            if (newItem == null || listView1.SelectedIndices.Count != 1)
                return;

            listView1.Items[listView1.SelectedIndices[0]] = newItem;

            tempList.Add(new ContinutUpdate<Tip>(newItem.CustomStruct, ContinutUpdateType.MODIFY));
        }
        /// <summary>
        /// Adauga tipul in lista
        /// </summary>
        private void AdaugaTip()
        {
            var newItem = GetTip();
            if (newItem == null)
                return;

            foreach (var item in listView1.Items)
            {
                CustomListViewItem<Tip> listItem = item as CustomListViewItem<Tip>;
                if (listItem == null)
                    continue;
                if (listItem.CustomStruct.Nume.Equals(newItem.CustomStruct.Nume))
                    return;
            }

            listView1.Items.Add(newItem);

            tempList.Add(new ContinutUpdate<Tip>(newItem.CustomStruct, ContinutUpdateType.ADD));
        }
        /// <summary>
        /// Seteaza pe forma informatiile despre tip
        /// </summary>
        private void SetTipInformation()
        {
            if (_selectedTip == null)
                return;
            txtNume.Text = _selectedTip.Nume;
        }

        /// <summary>
        /// Salveaza modificarile facute tipurilor
        /// </summary>
        private void SaveChanges()
        {
            ContinutHandler.Instance.TipuriContinut.AddRange(tempList);
            ResourcesHandler.Instance.ListaTipuri.Clear();
            foreach (CustomListViewItem<Tip> continut in listView1.Items)
            {
                ResourcesHandler.Instance.ListaTipuri.Add(continut.CustomStruct);
            }
        }

        #endregion
    }
}