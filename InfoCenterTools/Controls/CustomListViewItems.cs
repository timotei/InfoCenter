// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System.Windows.Forms;

namespace InfoCenter.Controls
{
    /// <summary>
    /// Creaza un ListViewItem pe baza tipului specificat
    /// </summary>
    /// <typeparam name="T">Tipul structuri care o va contine acest ListViewItem</typeparam>
    public class CustomListViewItem<T> : ListViewItem
    {
        /// <summary>
        /// Structura custom asignata ListViewItem-ului
        /// </summary>
        public T CustomStruct { get; set; }

        public CustomListViewItem(string text, T customStruct)
            : base(text)
        {
            CustomStruct = customStruct;
        }

        public CustomListViewItem(string text, T customStruct, ListViewGroup group)
            : base(text,group)
        {
            CustomStruct = customStruct;
        }

        public CustomListViewItem(string[] text, T customStruct)
            : base(text)
        {
            CustomStruct = customStruct;
        }
    }
}
