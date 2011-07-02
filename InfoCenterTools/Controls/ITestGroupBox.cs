// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using InfoCenter.Classes;

namespace InfoCenter.Controls
{
    public interface ITestGroupBox
    {
        void SetIntrebareNr(int nr);
        bool ValidateRaspuns(bool markOnForm);
        void SetControlsState(bool state);
        int NrCrt
        {
            get;
            set;
        }
        string Raspuns
        {
            get;
        }
        IntrebareTest Intrebare
        {
            get;
            set;
        }
    }
}
