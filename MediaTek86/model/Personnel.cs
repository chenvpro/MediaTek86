namespace MediaTek86.model
{
    /// <summary>
    /// classe métier liée à la table Personnel
    /// </summary>
    class Personnel
    {
        /// <summary>
        /// clé primaire de la classe personnel
        /// </summary>
        public int idpersonnel { get; }
        /// <summary>
        /// propriété nom de la classe personnel
        /// </summary>
        public string nom { get; }
        /// <summary>
        /// propriété prenom de la classe personnel
        /// </summary>
        public string prenom { get; }
        /// <summary>
        /// propriété tel de la classe personnel
        /// </summary>
        public string tel { get; }
        /// <summary>
        /// propriété mail de la classe personnel
        /// </summary>
        public string mail { get; }
        /// <summary>
        /// constructeur de la classe personnel qui permet de remplir ses propriétés
        /// </summary>
        /// <param name="idpersonnel">clé primaire de la classe personnel</param>
        /// <param name="nom">propriété nom de la classe personnel qui donne le nom du personnel</param>
        /// <param name="prenom">propriété prenom de la classe personnel qui donne le prenom du personnel</param>
        /// <param name="tel">propriété tel de la classe personnel qui donne le numéro de téléphone du personnel</param>
        /// <param name="mail">propriété mail de la classe personnel qui donne le mail du personnel</param>
        public Personnel (int idpersonnel, string nom, string prenom, string tel, string mail)
        {
            this.idpersonnel = idpersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
        }

    }
}
