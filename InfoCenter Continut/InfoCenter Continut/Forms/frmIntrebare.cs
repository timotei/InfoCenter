// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using InfoCenter.Classes;
using Telerik.WinControls;

namespace InfoCenter.Forms
{
    public abstract class FrmIntrebare : RadForm
    {
        /// <summary>
        /// Intrebarea asociata formei
        /// </summary>
        public abstract IntrebareTest Intrebare { get; set; }
        /// <summary>
        /// Id-ul testului caruia ii este asociata intrebarea
        /// </summary>
        public abstract int IdTest { get; set; }
        /// <summary>
        /// Seteaza informatiile intrebarii pe forma
        /// </summary>
        public abstract void SetIntrebareInformation();
    }
}