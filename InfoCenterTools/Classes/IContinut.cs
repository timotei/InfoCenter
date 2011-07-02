// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk

namespace InfoCenter.Classes
{
    /// <summary>
    /// Interfata tipului de continut din InfoCenter
    /// </summary>
    public interface IContinut
    {
        string Titlu { get; set; }
        int Id { get; }
    }
}
