/*
   Copyright (C) 2007 - 2011 by Timotei Dolean <timotei21@gmail.com>
   Part of the Info Center Project

   This program is free software; you can redistribute it and/or modify
   it under the terms of the GNU General Public License as published by
   the Free Software Foundation; either version 2 of the License, or
   (at your option) any later version.
   This program is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY.

   See the LICENSE file for more details.
*/
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using InfoCenter.Forms;

namespace InfoCenter.Classes
{
    public class Splasher
    {
        /// <summary>
        /// Forma care o afiseaza splash-erul
        /// </summary>
        private static FrmSplash _splashForm;
        /// <summary>
        /// Thread-ul in care este creat splasher-ul
        /// </summary>
        private static Thread _splashThread;

        /// <summary>
        /// Arata ecranul de splash
        /// </summary>
        public static void Show(Icon icon, Image backgroundImage)
        {
            if (_splashThread != null)
                return;

            _splashThread = new Thread(delegate()
                                           {
                                               try
                                               {
                                                   _splashForm = new FrmSplash(icon,backgroundImage);
                                                   Application.Run(_splashForm);
                                               }
                                               catch (Exception)
                                               { }

                                           });
            
            _splashThread.IsBackground = true;
            _splashThread.Start();
        }

        /// <summary>
        /// Seteaza status-ul aplicatiei
        /// </summary>
        public static string Status
        {
            set
            {
                if (_splashForm == null)
                    return;
                try
                {
                    _splashForm.Invoke(new MethodInvoker(() => _splashForm.SetStatus(value)));
                }
                catch(Exception)
                {}
            }
        }

        /// <summary>
        /// Inchide splash-ul
        /// </summary>
        public static void Close()
        {
            if (_splashThread == null || _splashForm == null)
                return;

            try
            {
                _splashForm.Invoke(new MethodInvoker(_splashForm.Close));

                _splashThread.Abort();
                _splashThread = null;
                _splashForm = null;
            }
            catch (Exception)
            { }
        }
    }
}