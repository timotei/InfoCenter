// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System.Drawing;
using Telerik.WinControls.UI;

namespace InfoCenter.Controls
{
    public class CustomGridViewTextBoxColumn<T>:GridViewTextBoxColumn where T:class
    {
        public T CustomStruct { get; set; }

        public CustomGridViewTextBoxColumn()
        {
            CustomStruct = null;
            DataType = typeof(T);
            ReadOnly = true;
        }
        public CustomGridViewTextBoxColumn(T customStruct)
        {
            CustomStruct = customStruct;
            DataType = typeof(T);
            ReadOnly = true;
        }

        public CustomGridViewTextBoxColumn(string uniqueName, string fieldName, T custromStruct)
            : base(uniqueName, fieldName)
        {
            CustomStruct = custromStruct;
            DataType = typeof(T);
            ReadOnly = true;
        }
    }
    public class CustomGridViewCommandColumn :GridViewCommandColumn
    {
        public CustomGridViewCommandColumn()
        {
            UseDefaultText = true;
            DefaultText = " ";
            DataType = typeof(Image);
            ImageLayout = System.Windows.Forms.ImageLayout.Center;
        }
        public CustomGridViewCommandColumn(string uniqueName, string fieldName)
            : base(uniqueName, fieldName)
        {
            UseDefaultText = true;
            DefaultText = " ";
            DataType = typeof(Image);
            ImageLayout = System.Windows.Forms.ImageLayout.Center;
        }
    }
}
