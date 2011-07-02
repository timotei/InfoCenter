// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk

namespace InfoCenter.Classes
{
    /// <summary>
    /// Tine evidenta unui eveniment
    /// </summary>
    public struct InfoCenterEvent
    {
        /// <summary>
        /// Mesajul evenimentului
        /// </summary>
        public string Message { get; set; }
        public bool Dev;

        /// <summary>
        /// Initializeaza o noua structura de eveniment
        /// </summary>
        /// <param name="message">Mesajul</param>
        /// <param name="dev">Pentru developeri</param>
        public InfoCenterEvent(string message, bool dev)
            : this()
        {
            Message = message;
            Dev = dev;
        }
    }
}
