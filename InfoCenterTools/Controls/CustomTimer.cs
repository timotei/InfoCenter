// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace InfoCenter.Controls
{
    /// <summary>
    /// Contor de tip custom
    /// </summary>
    public class CustomTimer : Timer
    {
        /// <summary>
        /// Returneaza secundele scurse de la pornirea contorului
        /// </summary>
        public int Seconds { get; set; }
        /// <summary>
        /// Returneaza minutele scurse de la pornirea contorului
        /// </summary>
        public int Minutes { get; set; }
        /// <summary>
        /// Returneaza orele scurse de la pornirea contorului
        /// </summary>
        public int Hours { get; set; }
        /// <summary>
        /// Reprezinta starea contorului
        /// </summary>
        public bool _started { get; set; }

        public CustomTimer(IContainer container)
            : base(container)
        {
        }
        public CustomTimer()
        {
        }

        protected override void OnTick(EventArgs e)
        {
            base.OnTick(e);
            Seconds++;
            if (Seconds >= 60)
            {
                Minutes++;
                Seconds -= 60;
            }
            if (Minutes >= 60)
            {
                Hours++;
                Minutes -= 60;
            }
        }

        /// <summary>
        /// Porneste contorul
        /// </summary>
        public new void Start()
        {
            _started = true;
            Seconds = Minutes = Hours = 0;
            base.Start();
        }
        
        /// <summary>
        /// Opreste contorul
        /// </summary>
        public new void Stop()
        {
            _started = false;
            base.Stop();
        }

        public override string ToString()
        {
            return string.Format("{0}h {1}m {2}s", Hours, Minutes, Seconds);
        }

        /// <summary>
        /// Returneaza adevarat daca contorul este pornit
        /// </summary>
        public bool IsStarted
        {
            get { return _started; }
        }
    }
}