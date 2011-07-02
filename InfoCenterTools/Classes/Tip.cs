// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk

namespace InfoCenter.Classes
{
    /// <summary>
    /// Reprezinta tipul unui continut
    /// </summary>
    public class Tip
    {
        /// <summary>
        /// Id-ul tipului
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// Numele tipului
        /// </summary>
        public string Nume { get; set; }

        /// <summary>
        /// Initializeaza un tip nou
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="nume">Numele tipului</param>
        public Tip(int id, string nume)
        {
            Id = id;
            Nume = nume;
        }

        public override string ToString()
        {
            return string.Format("[Tip] - Id:{0},Nume:{1}", Id, Nume);
        }
    }
}
