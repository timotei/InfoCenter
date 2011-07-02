// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System.Collections.Generic;
using InfoCenter.Classes;
using Telerik.WinControls.UI;

namespace InfoCenter.Controls
{
    /// <summary>
    /// Reprezinta un CustomTreeNode care contine un anumit tip de structura
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CustomTreeNode<T> : RadTreeNode
    {
        /// <summary>
        /// Returneaza structura care o contine nodul
        /// </summary>
        public T CustomStruct { get; set; }
        /// <summary>
        /// Returneaza adevarat daca acest nod este parinte
        /// </summary>
        public bool CustomParent { get; set; }
        /// <summary>
        /// Returneaza lista de probleme asociata nodului
        /// </summary>
        public List<Problema> ListaProbleme { get; set; }
        
        public CustomTreeNode(string text, T customStruct, bool customParent)
            : base(text)
        {
            CustomStruct = customStruct;
            CustomParent = customParent;
        }

        public CustomTreeNode(string text, IEnumerable<RadTreeNode> children, T customStruct, bool customParent)
            : this(text,customStruct,customParent)
        {
            Nodes.AddRange(children);
        }

        /// <summary>
        /// Returneaza adevarat daca acest nod este parinte
        /// </summary>
        public bool IsCustomParent
        {
            get { return CustomParent; }
        }
    }
}