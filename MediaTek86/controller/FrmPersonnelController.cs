using MediaTek86.dal;
using MediaTek86.model;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MediaTek86.controller
{
    /// <summary>
    /// contrôleur de FrmPersonnel
    /// </summary>
    class FrmPersonnelController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Personnel
        /// </summary>
        private readonly AccessPersonnel accesspersonnel;
        /// <summary>
        /// objet d'accès aux opérations possibles sur Absence
        /// </summary>
        private readonly AccessAbsence accessabsence;
        /// <summary>
        /// récupère les accès aux données
        /// </summary>
        public FrmPersonnelController()
        {
            accesspersonnel = new AccessPersonnel();
            accessabsence = new AccessAbsence();
        }
        /// <summary>
        /// récupère et retourne les infos des membres du personnel
        /// </summary>
        /// <returns></returns>
        public List<Personnel> GetLePersonnel()
        {
            return accesspersonnel.GetLePersonnel();
        }
        /// <summary>
        /// demande de suppression d'un membre du personnel
        /// </summary>
        /// <param name="personnel">objet de type personnel</param>
        public void DelPersonnel(Personnel personnel)
        {
            accesspersonnel.DelPersonnel(personnel);
        }
        /// <summary>
        /// demande d'ajout d'un nouveau membre dans le personnel
        /// </summary>
        /// <param name="personnel">objet de type personnel</param>
        public void AddPersonnel(Personnel personnel)
        {
            accesspersonnel.AddPersonnel(personnel);
        }
        /// <summary>
        /// demande de modification d'informations sur un membre du personnel déjà existant
        /// </summary>
        /// <param name="personnel">objet de type personnel</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            accesspersonnel.UpdatePersonnel(personnel);
        }
    }
}
