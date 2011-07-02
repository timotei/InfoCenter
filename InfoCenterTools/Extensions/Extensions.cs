// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using Telerik.WinControls.UI;
using System.Text;

namespace InfoCenter.Extensions
{
    public static class Extensions
    {
        /// <summary>
        /// Returneaza numarul de randuri selectate din grid
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int CountSelected(this RadGridView grid)
        {
            int count = 0;
            foreach (var row in grid.Rows)
            {
                if (row.Cells[1].Value.ToString().ToLower().Equals("true"))
                    count++;
            }
            return count;
        }

        /// <summary>
        /// Inlocuieste toate aparitiile fiecarui sir din vector cu sirul specificat
        /// </summary>
        /// <param name="text">Textul initial</param>
        /// <param name="stringsToReplace">Sirurile de inlocuit</param>
        /// <param name="newString">Sirul nou care va inlocui sirurile cautate</param>
        /// <param name="toLower">Adevarat daca se doreste convertirea la litere mici</param>
        /// <returns></returns>
        public static string ReplaceAll(this string text, string[] stringsToReplace, string newString, bool toLower)
        {
            if (toLower)
                text = text.ToLower();
            StringBuilder stringBuilder =new StringBuilder(text);
            foreach (string str in stringsToReplace)
            {
                stringBuilder = stringBuilder.Replace(str, newString);
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Returneaza adevarat daca gaseste in vectorul de string-uri, valoarea specificata
        /// </summary>
        /// <param name="stringArray">Vectorul specificat</param>
        /// <param name="value">Valoarea cautata</param>
        /// <returns></returns>
        public static bool Contains(this string[] stringArray, string value)
        {
            foreach (var item in stringArray)
                if (item.Contains(value))
                    return true;

            return false;
        }

        public static bool EqualsTo(this string[] stringArray, string value)
        {
            foreach (var item in stringArray)
                if (item.Equals(value))
                    return true;

            return false;
        }
        /// <summary>
        /// Returneaza adevarat daca gaseste in string-ul specificat unul dintre valorile vectorului
        /// </summary>
        /// <param name="myString"></param>
        /// <param name="stringArray"></param>
        /// <returns></returns>
        public static bool Contains(this string myString, string[] stringArray)
        {
            foreach (var item in stringArray)
                if (myString.Contains(item))
                    return true;

            return false;
        }
        /// <summary>
        /// Returneaza indexul daca gaseste in string-ul specificat unul dintre valorile vectorului
        /// </summary>
        /// <param name="myString"></param>
        /// <param name="stringArray"></param>
        /// <returns></returns>
        public static int GetIndexContains(this string myString, string[] stringArray)
        {
            for (int i = 0; i < stringArray.Length; i++)
                if (myString.Contains(stringArray[i]))
                    return i;

            return -1;
        }
    
        /// <summary>
        /// Returneaza valoarea string-ului curent ca si un numar int
        /// </summary>
        /// <param name="myString"></param>
        /// <returns></returns>
        public static int ToInt(this string myString)
        {
            int toInt;
            int.TryParse(myString,out toInt);
            return toInt;
        }
    }
}
