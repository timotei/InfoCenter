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
using System.Text;

namespace InfoCenter.Util
{
    /// <summary>
    /// Contine utilitati pentru codarea unor date
    /// </summary>
    public static class EncodingUtil
    {
        /// <summary>
        /// Encodeaza textul in base 64, cu sau fara deviatie
        /// </summary>
        /// <param name="text">Textul</param>
        /// <param name="deviation">Adevarat daca se deviaza textul</param>
        /// <returns></returns>
        public static string EncodeBase64(string text, bool deviation)
        {
            try
            {
                byte[] encData_byte = Encoding.UTF8.GetBytes(text);
                string encodedData = Convert.ToBase64String(encData_byte);
                if (deviation)
                    return Deviate(encodedData, text.Length) + "%" + text.Length;
                return encodedData;
            }
            catch (Exception)
            {
                return "";
            }
        }

        /// <summary>
        /// Decodeaza textul din base 64
        /// </summary>
        /// <param name="text">Textul</param>
        /// <param name="deviation">Adevarat daca textul este deviat</param>
        /// <returns></returns>
        public static string DecodeBase64(string text, bool deviation)
        {
            try
            {
                var encoder = new UTF8Encoding();
                Decoder utf8Decode = encoder.GetDecoder();

                if (deviation)
                {
                    // lungimea initiala a textului codat (dupa %)
                    int initialLength;
                    int indexOf = text.LastIndexOf('%');
                    int.TryParse(text.Substring(indexOf + 1), out initialLength);
                    text = Deviate(text.Substring(0, indexOf), -initialLength);
                }

                byte[] todecode_byte = Convert.FromBase64String(text);
                int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
                char[] decoded_char = new char[charCount];
                utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
                string result = new String(decoded_char);
                return result;
            }
            catch (Exception)
            {
                return "";
            }
        }

        /// <summary>
        /// Deviaza un text cu deviatia specificata
        /// </summary>
        /// <param name="text">Textul</param>
        /// <param name="deviation">Deviatia</param>
        /// <returns></returns>
        private static string Deviate(string text, int deviation)
        {
            char[] newString = text.ToCharArray();
            for (int i = 0; i < newString.Length; i++)
            {
                newString[i] = (char)(newString[i] + deviation);
            }
            return new string(newString);
        }
    }
}