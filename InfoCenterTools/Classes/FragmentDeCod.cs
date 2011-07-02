using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace InfoCenter.Classes
{
     /// <summary>
    /// Reprezinta un fragment de cod
    /// </summary>
    public class FragmentDeCod
    {
        /// <summary>
        /// Id-ul fragmentului de cod
        /// </summary>
        [XmlAttribute("id")]
        public int Id { get; set; }

        /// <summary>
        /// Returneaza codul sursa atasat fragmentului de cod
        /// </summary>
        [XmlText(typeof(string))]
        public string CodSursa { get; set; }

        /// <summary>
        /// Returneaza titlul fragmentului de cod
        /// </summary>
        [XmlAttribute("titlu")]
        public string Titlu { get; set; }

        /// <summary>
        /// Returneaza autorul fragmentului de cod
        /// </summary>
        [XmlAttribute("autor")]
        public string Autor { get; set; }

        /// <summary>
        /// Initializeaza un nou fragment de cod
        /// </summary>
        /// <param name="id">Id-ul asociat</param>
        /// <param name="codSursa">Codul sursa asociat</param>
        /// <param name="titlu">Titlul codului sursa</param>
        /// <param name="autor">Autorul codului sursa</param>
        public FragmentDeCod(int id,string codSursa, string titlu, string autor)
        {
            Id = id;
            CodSursa = codSursa;
            Titlu = titlu;
            Autor = autor;
        }

        public FragmentDeCod()
        {
            CodSursa = Titlu = Autor = string.Empty;
        }
    }

    
    /// <summary>
    /// Tine evidenta fragmentelor de cod
    /// </summary>
    [XmlRoot("codesnippets")]
    [Serializable]
    public class FragmenteDeCodHolder
    {
        public FragmenteDeCodHolder()
        {
            FragmenteDeCod = new List<FragmentDeCod>();
        }

        /// <summary>
        /// Returneaza o lista cu fragmentele de cod continute
        /// </summary>
        [XmlElement("codesnippet")]
        public List<FragmentDeCod> FragmenteDeCod { get; set; }
    }
}
