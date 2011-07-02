// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
namespace InfoCenter.Classes
{
    /// <summary>
    /// Reprezinta unitatea de testare pentru o problema
    /// </summary>
    public class UnitateTestare
    {
        /// <summary>
        /// Id-ul unitati de testare
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// Id-ul problemei asociate
        /// </summary>
        public int IdProblema { get; set; }
        /// <summary>
        /// Numele unitatii de testare
        /// </summary>
        public string Nume { get; set; }
        /// <summary>
        /// Datele de intrare
        /// </summary>
        public string DateIntrare { get; set; }
        /// <summary>
        /// Datele de iesire
        /// </summary>
        public string DateIesire { get; set; }
        /// <summary>
        /// Datele date de utilizator
        /// </summary>
        public string DateUtilizator { get; set; }

        /// <summary>
        /// Initializeaza o unitate de testare
        /// </summary>
        /// <param name="id">ID-ul</param>
        /// <param name="idProblema">ID-ul problemei</param>
        /// <param name="nume">Numele unitati de testare</param>
        /// <param name="dateIntrare">Datele de intrare</param>
        /// <param name="dateIesire">Datele de iesire</param>
        public UnitateTestare(int id, int idProblema, string nume, string dateIntrare, string dateIesire)
        {
            Id = id;
            Nume = nume;
            IdProblema = idProblema;
            DateIntrare = dateIntrare;
            DateIesire = dateIesire;
        }

        /// <summary>
        /// Returneaza adevarat daca Datele de iesire sunt identice cu cele specificate
        /// </summary>
        /// <param name="output">Date de iesire pentru comparatie</param>
        /// <returns></returns>
        public bool CheckOutput(string output)
        {
            string[] outputArray = output.Replace("\r\n"," ").Trim().Split(' ');
            string[] correctArray = DateIesire.Replace("\r\n"," ").Trim().Split(' ');

            if (outputArray.Length != correctArray.Length)
                return false;

            for (int i = 0; i < outputArray.Length; i++)
                if (!outputArray[i].Trim().Equals(correctArray[i].Trim()))
                    return false;

            return true;
        }

        public override string ToString()
        {
            return Nume;
        }
    }
}