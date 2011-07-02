// Copyright © 2007-2009 Timotei Dolean (Liceul de Informatica "Tiberiu Popoviciu" - Cluj-Napoca)
// e-mail: timotei_cluj@yahoo.co.uk
namespace InfoCenter.Classes
{
    /// <summary>
    /// Tipul de update al continutului
    /// </summary>
    public enum ContinutUpdateType { ADD, DELETE, MODIFY, NONE }

    /// <summary>
    /// Contine informatie legata update
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ContinutUpdate<T>
    {
        /// <summary>
        /// Structura custom asociata update-ului
        /// </summary>
        public T CustomStruct { get; set; }
        /// <summary>
        /// Tipul update-ului
        /// </summary>
        public ContinutUpdateType UpdateType { get; set; }

        public ContinutUpdate(T customStruct, ContinutUpdateType type)
        {
            CustomStruct = customStruct;
            UpdateType = type;
        }

        public override string ToString()
        {
            return string.Format("{0} - UpdateType:{1}", CustomStruct.GetType(), UpdateType);
        }
    }
}