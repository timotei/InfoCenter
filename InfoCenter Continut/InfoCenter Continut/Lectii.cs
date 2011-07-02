// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using InfoCenter.Classes;
using InfoCenter.Controls;
using InfoCenter.Util;
using Res = InfoCenter.Handlers.ResourcesHandler;

namespace InfoCenter
{
    partial class MainForm
    {
        /// <summary>
        /// Salveaza modificarile efecutate lectiei
        /// </summary>
        private void SaveChangesLectie()
        {
            if (treeViewLectii.SelectedNode == null)
                return;
            var treeNode = (CustomTreeNode<Lectie>)treeViewLectii.SelectedNode;
            var newNode = GetLectieTreeNode(true);

            if (newNode == null)
                return;

            if (treeNode.CustomStruct.Id != newNode.CustomStruct.Id)
            {
                Res.Instance.IdsLectii.Remove(treeNode.CustomStruct.Id);
                Res.Instance.IdsLectii.Add(newNode.CustomStruct.Id);
            }

            treeNode.CustomStruct = newNode.CustomStruct;
            treeNode.Text = treeNode.CustomStruct.Titlu;
            SetStatus(Messages.LECTIE_SAVED, "ok");
        }
        /// <summary>
        /// Adauga o lectie noua la nivel inferior al celui selectat
        /// </summary>
        private void AddInferiorLectie()
        {
            if (Res.Instance.SelectedLectie != null)
            {
                Messages.ShowMessageBox(Messages.LECTIE_ALREADY_ADDED, "warn");
                SetStatus(Messages.LECTIE_ALREADY_ADDED, "warn");
                return;
            }

            if (treeViewLectii.SelectedNode == null)
            {
                Messages.ShowMessageBox(Messages.NO_LECTIE_SELECTED_ARRAY[0], "warn");
                SetStatus(Messages.NO_LECTIE_SELECTED_ARRAY[0], "warn");
                return;
            }

            CustomTreeNode<Lectie> lectie = GetLectieTreeNode(false);
            if (lectie == null)
                return;

            Res.Instance.IdsLectii.Add(lectie.CustomStruct.Id);

            var treeNode = ((CustomTreeNode<Lectie>)treeViewLectii.SelectedNode);

            treeNode.Nodes.Add(lectie);
            if (treeNode.CustomStruct.Lectii == null)
                treeNode.CustomStruct.Lectii = new List<Lectie>();

            treeNode.CustomStruct.Lectii.Add(lectie.CustomStruct);
            SetStatus(Messages.LECTIE_ADDED, "ok");
            SetNewLectie();
        }
        /// <summary>
        /// Adauga o lectie noua la acelasi nivel cu cea selectata
        /// </summary>
        private void AddLectie()
        {
            if (Res.Instance.SelectedLectie != null)
            {
                Messages.ShowMessageBox(Messages.LECTIE_ALREADY_ADDED, "warn");
                SetStatus(Messages.LECTIE_ALREADY_ADDED, "warn");
                return;
            }

            CustomTreeNode<Lectie> lectie = GetLectieTreeNode(false);
            if (lectie == null)
                return;

            if (treeViewLectii.SelectedNode == null ||
                treeViewLectii.SelectedNode.Parent == null) // radacina
            {
                treeViewLectii.Nodes.Add(lectie);
            }
            else
            {
                treeViewLectii.SelectedNode.Parent.Nodes.Add(lectie);
                (treeViewLectii.SelectedNode.Parent as CustomTreeNode<Lectie>).
                    CustomStruct.Lectii.Add(lectie.CustomStruct);
            }

            Res.Instance.IdsLectii.Add(lectie.CustomStruct.Id);

            SetStatus(Messages.LECTIE_ADDED, "ok");
            SetNewLectie();
        }
        /// <summary>
        /// Reseteaza campurile de pe forma pentru a completa o noua lectie
        /// </summary>
        private void SetNewLectie()
        {
            Res.Instance.SelectedLectie = null;
            txtLocatieLectie.Text = txtProblemeAsociate.Text =
                txtTesteAsociate.Text = txtTitluLectie.Text = "";
            comboBoxDificultateLectie.Text = "1";
            btnStergeLectie.Enabled = false;
        }
        /// <summary>
        /// Seteaza informatiile despre lectia selectata
        /// </summary>
        private void SetLectieInformation()
        {
            Lectie lectie = Res.Instance.SelectedLectie;
            if (lectie == null)
                return;

            txtTitluLectie.Text = lectie.Titlu;
            if (lectie.IsBrowsable)
                txtLocatieLectie.Text = Config.AppDataPath + lectie.LocatieLectie;
            else
                txtLocatieLectie.Text = "";
            comboBoxDificultateLectie.Text = lectie.Dificultate.ToString();
            txtProblemeAsociate.Text = lectie.IdsProbleme;
            txtTesteAsociate.Text = lectie.IdsTeste;

            btnStergeLectie.Enabled = true;
        }
        /// <summary>
        /// Sterge lectia selectata
        /// </summary>
        private void DeleteSelectedLectie()
        {
            if (treeViewLectii.SelectedNode == null)
            {
                Messages.ShowMessageBox(Messages.NO_LECTIE_SELECTED_ARRAY[0], "warn");
                SetStatus(Messages.NO_LECTIE_SELECTED_ARRAY[0], "warn");
                return;
            }

            if (treeViewLectii.SelectedNode.Nodes != null &&
                treeViewLectii.SelectedNode.Nodes.Count > 0) // am subnoduri
                if (Messages.ShowMessageBox(Messages.LECTIE_CONTAINS_SUBNODES_ARRAY[0],
                    Messages.LECTIE_CONTAINS_SUBNODES_ARRAY[1],"question") == DialogResult.No)
                    return;

            if (treeViewLectii.SelectedNode.Parent == null)
            {
                //LectiiHandler.Instance.LectiiHolder.ListaLectii.Remove(((CustomTreeNode<Lectie>)treeViewLectii.SelectedNode).CustomStruct);
                treeViewLectii.Nodes.Remove(treeViewLectii.SelectedNode);
            }
            else
            {
                (treeViewLectii.SelectedNode.Parent as CustomTreeNode<Lectie>).CustomStruct.Lectii.Remove(
                    (treeViewLectii.SelectedNode as CustomTreeNode<Lectie>).CustomStruct);
                treeViewLectii.SelectedNode.Parent.Nodes.Remove(treeViewLectii.SelectedNode);
            }

            treeViewLectii.Invalidate();

            Res.Instance.RemoveLectie(Res.Instance.SelectedLectie);
            Res.Instance.SelectedLectie = null;

            SetNewLectie();
            SetStatus(Messages.LECTIE_DELETED, "ok");
        }
        /// <summary>
        /// Returneaza nodul care contine lectia de pe forma.
        /// </summary>
        /// <param name="save">Adevarat daca se salveaza modificarile</param>
        /// <returns></returns>
        private CustomTreeNode<Lectie> GetLectieTreeNode(bool save)
        {
            int id;
            if (save)
            {
                if (Res.Instance.SelectedLectie == null)
                    return null;
                id = Res.Instance.SelectedLectie.Id;
            }
            else
                id = Res.Instance.GetNextAvailableLectieId();

            if (txtTitluLectie.Text.Length == 0)
            {
                errorProvider.SetError(txtTitluLectie, Messages.TITLE_UNSPECIFIED);
                return null;
            }
            errorProvider.SetError(txtTitluLectie, "");


            int difficulty;
            int.TryParse(comboBoxDificultateLectie.Text, out difficulty);
            if (difficulty == 0 || (difficulty < 1 && difficulty > 3))
            {
                errorProvider.SetError(comboBoxDificultateLectie, Messages.INCORRECT_VALUE);
                return null;
            }
            errorProvider.SetError(comboBoxDificultateLectie, "");

            string file_path = txtLocatieLectie.Text;
            if (file_path.Contains(Config.AppDataPath))
                file_path = file_path.Substring(Config.AppDataPath.Length);

            if (file_path.Length != 0 && !File.Exists(Config.AppDataPath + file_path))
            {
                errorProvider.SetError(txtLocatieLectie, Messages.NO_FILE_EXIST);
                return null;
            }
            errorProvider.SetError(txtLocatieLectie, "");

            if (!ValidateTextBoxText(txtProblemeAsociate, true))
                return null;
            errorProvider.SetError(txtProblemeAsociate, "");

            if (!ValidateTextBoxText(txtTesteAsociate, true))
                return null;
            errorProvider.SetError(txtTesteAsociate, "");

            Lectie newLectie = new Lectie(id, txtTitluLectie.Text,
               file_path, difficulty, txtProblemeAsociate.Text, txtTesteAsociate.Text, null);
            return new CustomTreeNode<Lectie>(newLectie.Titlu, newLectie, false);
        }
    }
}