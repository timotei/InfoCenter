// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
using System.Diagnostics;
using System;
using System.IO;
using System.Threading;
using InfoCenter.Classes;
using InfoCenter.Controls;
using InfoCenter.Util;

namespace InfoCenter.Handlers
{
    /// <summary>
    /// Compileaza secvente de cod sau fisiere tinand cont de compilatorul folosit
    /// </summary>
    public sealed class CompilerHandler
    {
        #region Singleton
        private static CompilerHandler _Instance = new CompilerHandler();
        private CompilerHandler()
        {
            FilesInOutChecker = new CustomTimer();
        }
        public static CompilerHandler Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new CompilerHandler();
                return _Instance;
            }
        }
        #endregion
        #region Compilare

        /// <summary>
        /// Datele compilatorului C++
        /// </summary>
        public  CompilerData  CPPCompiler = new CompilerData("", "", CompilerType.CPP);
        /// <summary>
        /// Ultimul mesaj al compilatorului
        /// </summary>
        public  string        LastOutput = string.Empty;
        /// <summary>
        /// Ultima eroare a compilatorului
        /// </summary>
        public  string        LastError = string.Empty;
        /// <summary>
        /// Thread-ul compilatorului
        /// </summary>
        public  Thread        CompilerThread;
        /// <summary>
        /// Thread-ul pentru executarea fisierului compilat
        /// </summary>
        public  Thread       ExecuteCompiledFileThread;

        /// <summary>
        /// Textul care va fi inserat in console in la rularea codului sursa
        /// </summary>
        public  string ConsoleInputText = string.Empty;

        /// <summary>
        /// Textul afisat de program la rulare
        /// </summary>
        public  string ConsoleOutputText = string.Empty;

        /// <summary>
        /// Compileaza un text
        /// </summary>
        /// <param name="sourceText">Textul care trebuie compilat</param>
        /// <param name="compilerType">Tipul compilatorului</param>
        /// <returns></returns>
        public  bool CompileText(string sourceText, CompilerType compilerType)
        {
            return CompileText(sourceText, GetCompilerByType(compilerType));
        }
        /// <summary>
        /// Compileaza un text
        /// </summary>
        /// <param name="sourceText">Textul care trebuie compilat</param>
        /// <param name="compiler">Compilatorul folosit</param>
        /// <returns></returns>
        public  bool CompileText(string sourceText, CompilerData compiler)
        {
            if (compiler == null)
            {
                Messages.ShowMessageBox(Messages.INVALID_COMPILER_SELECTED, "warn");
                return false;
            }

            try
            {
                string tmpFileName = "tmpFile.";
                tmpFileName += compiler.SourceFileExtension;
                using (StreamWriter sw = new StreamWriter(Path.GetTempPath()+ tmpFileName,
                    false, System.Text.Encoding.ASCII))
                {
                    sw.WriteLine(sourceText);
                    sw.Flush();
                    return CompileFile(tmpFileName, compiler);
                }
            }
            catch (Exception e)
            {
                ExceptionsHandler.Instance.AddException(e, Messages.ERROR_COMPILE);
                return false;
            }
        }

        /// <summary>
        /// Compileaza fisierul cu cod sursa
        /// </summary>
        /// <param name="fileName">Numele fisierului</param>
        /// <param name="compiler">Compilatorul folosit</param>
        /// <returns></returns>
        public  bool CompileFile(string fileName, CompilerData compiler)
        {
            if (!compiler.HasValidPath)
            {
                Messages.ShowMessageBox(Messages.COMPILER_EXE_NOT_FOUND, "");
                return false;
            }

            try
            {
                // sterge si copiaza noul cod sursa
                if (File.Exists(compiler.WorkingPath + fileName))
                    File.Delete(compiler.WorkingPath + fileName);
                File.Copy(Path.GetTempPath() + fileName, compiler.WorkingPath + fileName);

                string exeFileName = Path.GetFileNameWithoutExtension(fileName) + ".exe";
                // sterge programul compilat anterior, daca exista
                //if (File.Exists(Path.Combine(compiler.WorkingPath,exeFileName)))
                //    File.Delete(Path.Combine(compiler.WorkingPath,exeFileName));
                
                // adauga ghilimele in cazul ca path-ul are spatii (eg: Program Files devine: "Program Files" )
                //compiler.FullPath = "\"" + compiler.FullPath + "\"";
                //compiler.WorkingPath = compiler.WorkingPath;

                Process proces = CreateProcess(compiler.FullPath, compiler.WorkingPath, 
                    compiler.GetArguments(fileName, exeFileName));
                proces.Start();
                proces.WaitForExit(5000);
                if (!proces.HasExited)
                    proces.Kill();

                LastOutput = proces.StandardOutput.ReadToEnd();
                LastError = proces.StandardError.ReadToEnd();
                return true;
            }
            catch (Exception e)
            {
                ExceptionsHandler.Instance.AddException(e, Messages.ERROR_COMPILE);
                return false;
            }
        }

        /// <summary>
        /// Creaza un proces si il returneaza, dupa datele primite
        /// </summary>
        /// <param name="fileName">Numele fisierului</param>
        /// <param name="workingDir">Folderul de lucru</param>
        /// <param name="arguments">Argumentele</param>
        /// <returns></returns>
        private  Process CreateProcess(string fileName, string workingDir, string arguments)
        {
            Process process = new Process
                                  {
                                      StartInfo =
                                          {
                                              FileName = fileName,
                                              Arguments = arguments,
                                              WorkingDirectory = workingDir,
                                              CreateNoWindow = true,
                                              ErrorDialog = true,
                                              RedirectStandardInput = true,
                                              RedirectStandardError = true,
                                              RedirectStandardOutput = true,
                                              UseShellExecute = false,
                                              WindowStyle = ProcessWindowStyle.Hidden
                                          }
                                  };
            return process;
        }

        /// <summary>
        /// Executa ultimul fisier compilat
        /// </summary>
        /// <returns></returns>
        public  bool ExecuteCompiledFile(CompilerData compilerData)
        {
            try
            {
                const string fileName = "tmpFile.exe";
                string workPath = compilerData.WorkingPath;
                if (!File.Exists(workPath + fileName))
                    return false;

                Process proces = CreateProcess(workPath + fileName, workPath, "");
                proces.Start();
                proces.StandardInput.WriteLine(ConsoleInputText);
                proces.WaitForExit(5000); // maxim 5 secunde
                if (!proces.HasExited) // daca nu a iesit il terminam
                {
                    proces.Kill();
                    ExceptionsHandler.Instance.AddException(new TimeoutException(Messages.PROGRAM_TERMINATED_TOO_LONG),
                        Messages.PROGRAM_TERMINATED_TOO_LONG);
                }
                ConsoleOutputText = proces.StandardOutput.ReadToEnd();
                return true;
            }
            catch (Exception e)
            {
                ExceptionsHandler.Instance.AddException(e, "");
                return false;
            }
        }
        #endregion

        /// <summary>
        /// Ceasul care se ocupa cu verificarea codului sursa pentru fisiere de intrare si iesire
        /// </summary>
        public CustomTimer FilesInOutChecker { get; set; }

        /// <summary>
        /// Returneaza un compilator dupa tipul specificat
        /// </summary>
        /// <param name="compilerType">Tipul compilatorului</param>
        /// <returns></returns>
        public  CompilerData GetCompilerByType(CompilerType compilerType)
        {
            switch (compilerType)
            {
                case CompilerType.CPP:
                    return CPPCompiler;
                default:
                    return null;
            }
        }
    }
}