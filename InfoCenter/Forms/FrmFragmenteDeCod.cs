using Telerik.WinControls;
using InfoCenter.Classes;
using InfoCenter.Util;
using InfoCenter.Controls;
using Res = InfoCenter.Handlers.ResourcesHandler;

namespace InfoCenter.Forms
{
    public partial class FrmFragmenteDeCod : RadForm
    {
        private FragmentDeCod _selectedSnippet;

        /// <summary>
        /// Returneaza Fragmentul de cod asociat
        /// </summary>
        public FragmentDeCod FragmentDeCod { get; set; }

        public FrmFragmenteDeCod()
        {
            InitializeComponent();
            txtCodSursa.SourceTextBox.SetHighlighting("C++.NET");
            foreach (var codeSnippet in Res.Instance.FragmenteDeCodHolder.FragmenteDeCod)
            {
                if (codeSnippet == null)
                    continue;

                listaCodeSnippets.Items.Add(new CustomListViewItem<FragmentDeCod>(codeSnippet.Titlu,
                    codeSnippet));
            }
        }

        private void btnInsertFragment_Click(object sender, System.EventArgs e)
        {
            FragmentDeCod = GetFragmentDeCod();
            if (FragmentDeCod != null)
            {
                DialogResult = System.Windows.Forms.DialogResult.Yes;
                Close();
            }
        }

        /// <summary>
        /// Returneaza fragmentul de cod asociat
        /// </summary>
        /// <returns></returns>
        private FragmentDeCod GetFragmentDeCod()
        {
            if (txtTitlu.Text.Length == 0 || txtCodSursa.Text.Length == 0)
            {
                Messages.ShowMessageBox(Messages.VALUES_UNSPECIFIED);
                return null;
            }

            int id;
            if (_selectedSnippet == null)
                id = Res.Instance.GetNextAvailableFragmentDeCodId();
            else
                id = _selectedSnippet.Id;
            
            return new FragmentDeCod(id,txtCodSursa.Text,txtTitlu.Text,txtAutor.Text);
        }

        private void btnNewFragment_Click(object sender, System.EventArgs e)
        {
            txtAutor.Text = txtCodSursa.Text = txtTitlu.Text = "";
            txtCodSursa.SourceTextBox.Invalidate();
            txtCodSursa.Invalidate();
            _selectedSnippet = null;
        }

        private void btnSaveFragment_Click(object sender, System.EventArgs e)
        {
            FragmentDeCod fragment = GetFragmentDeCod();
            if (fragment == null)
                return;
            if (_selectedSnippet == null)
            {
                listaCodeSnippets.Items.Add(new CustomListViewItem<FragmentDeCod>(fragment.Titlu,
                    fragment));
                Res.Instance.IdsFragmenteDeCod.Add(fragment.Id);
                Res.Instance.FragmenteDeCodHolder.FragmenteDeCod.Add(fragment);
            }
            else
            {
                if (listaCodeSnippets.SelectedItems.Count == 0 ||
                    !(listaCodeSnippets.SelectedItems[0] is CustomListViewItem<FragmentDeCod>))
                    return;
                (listaCodeSnippets.SelectedItems[0] as CustomListViewItem<FragmentDeCod>).CustomStruct = fragment;
                Res.Instance.FragmenteDeCodHolder.FragmenteDeCod[
                    Res.Instance.FragmenteDeCodHolder.FragmenteDeCod.IndexOf(_selectedSnippet)] = fragment;
            }
        }

        private void listaCodeSnippets_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (listaCodeSnippets.SelectedItems.Count == 0 ||
                !(listaCodeSnippets.SelectedItems[0] is CustomListViewItem<FragmentDeCod>))
                return;

            txtCodSursa.Text = "";
            txtCodSursa.Refresh();

            FragmentDeCod fragment = (listaCodeSnippets.SelectedItems[0] as 
                CustomListViewItem<FragmentDeCod>).CustomStruct;
            _selectedSnippet = fragment;
            
            txtTitlu.Text = fragment.Titlu;
            txtCodSursa.Text = fragment.CodSursa;            
            txtAutor.Text = fragment.Autor; 
        }

        private void btnDeleteFragment_Click(object sender, System.EventArgs e)
        {
            if (_selectedSnippet == null)
                return;

            Res.Instance.IdsFragmenteDeCod.Remove(_selectedSnippet.Id);
            Res.Instance.FragmenteDeCodHolder.FragmenteDeCod.Remove(_selectedSnippet);
            listaCodeSnippets.Items.Remove(listaCodeSnippets.SelectedItems[0]);
            txtAutor.Text = txtCodSursa.Text = txtTitlu.Text = "";
            txtCodSursa.SourceTextBox.Invalidate();
            txtCodSursa.Invalidate();
            _selectedSnippet = null;
        }
    }
}