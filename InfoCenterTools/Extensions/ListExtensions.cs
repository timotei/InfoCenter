// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using InfoCenter.Classes;

namespace InfoCenter.Extensions
{
    public static class ListExtensions
    {
        /// <summary>
        /// Converteste o lista de tipuri intrun sir de ListViewGrup
        /// </summary>
        /// <param name="list">Lista care se converteste</param>
        /// <returns></returns>
        public static ListViewGroup[] ToListViewGroupArray(this List<Tip> list)
        {
            return (from tip in list
                          select new ListViewGroup(tip.Nume) { Name = tip.Nume }).ToArray();
        }
        /// <summary>
        /// Returneaza adevarat daca lista contine un tip cu numele cautat
        /// </summary>
        /// <param name="list"></param>
        /// <param name="tipNume"></param>
        /// <returns></returns>
        public static bool ContainsTip(this List<Tip> list, string tipNume)
        {
            return (list.Find(tip => tipNume.ToLower().Equals(tip.Nume.ToLower())) != null);
        }

        /// <summary>
        /// Converteste lista de tipuri intr-un sir de string-uri
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static string[] AsStringArray(this List<Tip> list)
        {
            return (from Tip tip in list
                    select tip.Nume).ToArray();
        }
        /// <summary>
        /// Returneaza adevarat daca lista contine o setare cu numele cautat
        /// </summary>
        /// <param name="list"></param>
        /// <param name="settingName"></param>
        /// <returns></returns>
        public static bool ContainsSetting(this List<Setting> list, string settingName)
        {
            return (list.Find(setting => setting.Nume.ToLower().Equals(settingName.ToLower())) != null);
        }
        public static int IndexOfSetting(this List<Setting> list, string settingName)
        {
            foreach (Setting setting in list)
            {
                if (setting.Nume.ToLower().Equals(settingName.ToLower()))
                    return list.IndexOf(setting);
            }
            return -1;
        }
    }
}
