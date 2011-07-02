// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System.Collections.Generic;
using InfoCenter.Classes;
using InfoCenter.Util;

namespace InfoCenter.Handlers
{    
    /// <summary>
    /// Tine evidenta evenimentelo din aplicatie
    /// </summary>
    public sealed class EventsHandler
    {
        #region Singleton
        private static EventsHandler _Instance = new EventsHandler();
        private EventsHandler() { Events = new List<InfoCenterEvent>(); }
        public static EventsHandler Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new EventsHandler();
                return _Instance;
            }
        }
        #endregion
        /// <summary>
        /// Lista evenimentelor
        /// </summary>
        public List<InfoCenterEvent> Events { get; set; }
        /// <summary>
        /// Forma care afiseaza evenimentele
        /// </summary>
        public System.Windows.Forms.Form EventsForm { get; set; }

        /// <summary>
        /// Adauga un eveniment cu un anumit mesaj
        /// </summary>
        /// <param name="message">Mesajul</param>
        /// <param name="dev">Adevarat daca e pentru developeri</param>
        public void AddEvent(string message, bool dev)
        {
            Events.Add(new InfoCenterEvent(message, dev));
            Logging.Instance.Write(System.DateTime.Now + " |Event    | " + message);
        }
        /// <summary>
        /// Afiseaza fereastra cu evenimente
        /// </summary>
        public void ShowEventsWindow()
        {
            if (EventsForm == null)
                return;
            EventsForm.ShowDialog();
        }
    }
}
