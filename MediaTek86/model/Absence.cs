using System;

namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier liée à la table Absences
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// clé primaire de la classe absence 
        /// </summary>
        public DateTime datedebut { get; set; }
        /// <summary>
        /// propriété de la classe absence
        /// </summary>
        public DateTime datefin { get; set; }
        /// <summary>
        /// constructeur de la classe absence et qui permet de remplir ses propriétés
        /// </summary>
        /// <param name="datedebut">clé primaire de la classe qui représente la date du début de l'absence d'un personnel</param>
        /// <param name="datefin">propriété de la classe qui représente la date de la fin de l'absence d'un personnel</param>
        public Absence (DateTime datedebut, DateTime datefin)
        {
            this.datedebut = datedebut;
            this.datefin = datefin;
        }
    }
}
