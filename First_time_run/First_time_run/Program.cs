// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using Console = System.Console;

namespace InfoCenter.FirstTimeRun
{
    static class Program
    {
        public static int Main()
        {
            try
            {
                Console.Title = "Prima rulare Info Center";

                string appPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
                Console.WriteLine("Pregătesc programul pentru prima rulare...");

                // directoarele
                System.IO.Directory.CreateDirectory(appPath);
                System.IO.Directory.CreateDirectory(appPath + "\\InfoCenter");

                // fisierele arhiva
                Console.Write("Copiez fişierele...");
                CopyNeccessaryFiles(appPath + "\\");
                Console.WriteLine("\tOK");

                // Settings.Instance.xml
                Console.Write("Setările...");
                WriteSettingsXML(appPath);

                // cppcompiler.zip
                Console.Write("Compilator C++...");
                Unzip(appPath + @"\cppcompiler.zip", appPath, "nu gasesc arhiva compilatorului C++");

                // data.zip
                Console.Write("Conţinut...");
                Unzip(appPath + @"\InfoCenter\data.zip", appPath + @"\InfoCenter", "nu gasesc arhiva cu continut");

                Console.WriteLine("Success. Apăsaţi <ENTER> pentru a continua.");
                Console.Read();
            }
            catch (System.Exception e)
            {
                Console.WriteLine("EROARE {0}", e.Message);
                Console.Read();
            }

            return 0;
        }

        /// <summary>
        /// Copiaza fisierele necesare daca acestea nu exista
        /// </summary>
        /// <param name="folderDest">Destinatia de tip folder</param>
        private static void CopyNeccessaryFiles(string folderDest)
        {
            var neccessaryFiles = new[] {
                "cppcompiler.zip",
                @"InfoCenter\data.zip"
            };
            foreach (string file in neccessaryFiles)
            {
                if (!System.IO.File.Exists(System.AppDomain.CurrentDomain.BaseDirectory + "\\Data\\" + file))
                    // nu gasesc fisierul in directorul curent
                    continue;

                if (System.IO.File.Exists(folderDest + file)) // exista fisierul in directorul destinatie
                    continue;

                System.IO.File.Copy(System.AppDomain.CurrentDomain.BaseDirectory + "\\Data\\"+file,
                    folderDest + file);
            }
        }

        /// <summary>
        /// Extrage fisierele din fisierul .zip specificat in destinatia specificata.
        /// </summary>
        /// <param name="filePath">Locatia fisierului .zip</param>
        /// <param name="destPath">Destinatia</param>
        /// <param name="errorMessage">Mesajul de eroare in cazul negasirii fisierului</param>
        private static void Unzip(string filePath, string destPath, string errorMessage)
        {
            if (System.IO.File.Exists(filePath))
            {
                try
                {
                    var zip = new ICSharpCode.SharpZipLib.Zip.FastZip();
                    zip.ExtractZip(filePath, destPath, "");
                    Console.WriteLine("\tOK");
                }
                catch (System.Exception e)
                {
                    Console.WriteLine("EROARE {0}", e.Message);
                }
            }
            else
                Console.WriteLine("\tEroare - {0}", errorMessage);
        }

        /// <summary>
        /// Creeaza si scrie fisierul XML cu setari in folderul destinatie specificat
        /// </summary>
        /// <param name="destinationFolder">Folderul destinatie</param>
        private static void WriteSettingsXML(string destinationFolder)
        {
            var defaultXML = new System.Text.StringBuilder();
            defaultXML.AppendLine("<settings>");
            defaultXML.AppendLine("<setting name=\"CPPPath\" value=\"" + destinationFolder + "\\cppcompiler\\bin\\c++.exe\" />");
            defaultXML.AppendLine("<setting name=\"QuickSavePath\"  value=\"\" />");
            defaultXML.AppendLine("<setting name=\"CPPPattern\" value=\"{0} -o {1} -Wno-deprecated\" />");
            defaultXML.AppendLine("</settings>");

            using (var sw = new System.IO.StreamWriter(
                destinationFolder + @"\\InfoCenter\\Settings.xml"))
            {
                sw.Write(defaultXML);
                sw.Flush();
            }
            Console.WriteLine("\tOK");
        }
    }
}