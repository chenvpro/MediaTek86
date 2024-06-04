using System;
using System.Collections.Generic;

namespace MediaTek86.model
{
    /// <summary>
    /// classe métier liée à la table Service
    /// </summary>
    class Service
    {
        /// <summary>
        /// clé primaire de la classe service
        /// </summary>
        public int idservice { get; }
        /// <summary>
        /// propriété nom de la classe service
        /// </summary>
        public string nom { get; }
        /// <summary>
        /// constructeur de la classe service et qui permet de remplir ses propriétés
        /// </summary>
        /// <param name="idservice">clé primaire de la classe service</param>
        /// <param name="nom">propriété nom de la classe service qui donne le nom du service</param>
        public Service (int idservice, string nom)
        {
            this.idservice = idservice;
            this.nom = nom;
        }
    }
}
