namespace MediaTek86.model
{
    /// <summary>
    /// classe métier liée à la table Motif
    /// </summary>
    class Motif
    {
        /// <summary>
        /// clé primaire de la classe motif
        /// </summary>
        public int idmotif { get; }
        /// <summary>
        /// propriété libelle de la classe motif
        /// </summary>
        public string libelle { get; }
        /// <summary>
        /// constructeur de la classe. Permet de remplir les propriété de la classe motif
        /// </summary>
        /// <param name="idmotif">clé primaire de la classe motif</param>
        /// <param name="libelle">propriété de la classe motif qui représente la raison de l'absence</param>
        public Motif (int idmotif, string libelle)
        {
            this.idmotif = idmotif;
            this.libelle = libelle;
        }
    }
}
