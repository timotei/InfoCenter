using System;
using InfoCenter.Classes;
using InfoCenter.Util;

namespace InfoCenter.Handlers
{
    /// <summary>
    /// Tine evidenta fragmentelor de cod, salvare si incarcare din fisier
    /// </summary>
    internal sealed class FragmenteDeCodHandler
    {
        #region Singleton
        private static FragmenteDeCodHandler _Instance = new FragmenteDeCodHandler();
        private FragmenteDeCodHandler()
        {
            FragmenteDeCod = new FragmenteDeCodHolder();
        }
        public static FragmenteDeCodHandler Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new FragmenteDeCodHandler();
                return _Instance;
            }
        }
        #endregion
        /// <summary>
        /// Locatia fisierului cu fragmente de cod
        /// </summary>
        private string _filePath;

        /// <summary>
        /// Lista fragmentelor de cod
        /// </summary>
        public FragmenteDeCodHolder FragmenteDeCod { get; set; }

        /// <summary>
        /// Citeste si incarca fragmentele de cod
        /// </summary>
        /// <param name="filePath">Locatia fisierului cu fragmente de cod</param>
        /// <returns></returns>
        public bool ParseFile(string filePath)
        {
            _filePath = filePath;
            FragmenteDeCod = new FragmenteDeCodHolder();

            try
            {
                var xmls = new System.Xml.Serialization.XmlSerializer(typeof(FragmenteDeCodHolder));
                var streamReader = new System.IO.StreamReader(filePath, false);
                FragmenteDeCod = (FragmenteDeCodHolder)xmls.Deserialize(streamReader);

                return true;
            }
            catch (Exception e)
            {
                ExceptionsHandler.Instance.AddException(e, Messages.ERROR_LOAD_CODE_SNIPPETS);
                return false;
            }
        }
        /// <summary>
        /// Salveaza fisierul cu fragmente de cod
        /// </summary>
        /// <returns></returns>
        public bool SaveFile()
        {
            try
            {
                var xmls = new System.Xml.Serialization.XmlSerializer(typeof(FragmenteDeCodHolder));
                var streamWriter = new System.IO.StreamWriter(_filePath, false);
                xmls.Serialize(streamWriter, FragmenteDeCod);
                streamWriter.Close();
                return true;
            }
            catch (Exception e)
            {
                ExceptionsHandler.Instance.AddException(e, Messages.ERROR_SAVE_FILE);
                return false;
            }
        }
    }
}
