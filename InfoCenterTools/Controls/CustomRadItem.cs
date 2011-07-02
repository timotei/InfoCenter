// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using Telerik.WinControls.UI;

namespace InfoCenter.Controls
{
    /// <summary>
    /// Initializeaza un RadItem custom, care contine o structura generica
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CustomRadItem<T> : RadMenuItem
    {
        /// <summary>
        /// Structura custom asignata RadItem-ului
        /// </summary>
        public T CustomStruct { get; set; }

        public CustomRadItem(T customStruct)
        {
            CustomStruct = customStruct;
        }
    }
}
