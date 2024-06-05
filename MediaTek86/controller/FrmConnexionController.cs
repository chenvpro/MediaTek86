using System;
using MediaTek86.dal;
using MediaTek86.model;

namespace MediaTek86.controller
{
    /// <summary>
    /// contrôleur de FrmConnexion
    /// </summary>
    public class FrmConnexionController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur personnel
        /// </summary>
        private readonly AccessPersonnel accesspersonnel;
        /// <summary>
        /// récupère l'accès aux données
        /// </summary>
        public FrmConnexionController()
        {
            accesspersonnel = new AccessPersonnel();
        }
        /// <summary>
        /// vérifie les informations de connexion
        /// </summary>
        /// <param name="responsable">objet contenant les informations pour se connecter</param>
        /// <returns>vrai si les informations de connexion sont valides</returns>
        public Boolean ControleConnexion(Responsable responsable)
        {
            return accesspersonnel.ControleConnexion(responsable);
        }
    }
}
