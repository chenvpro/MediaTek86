using System;
using System.Collections.Generic;


namespace MediaTek86.model
{
    /// <summary>
    /// classe métier liée à la table responsable
    /// </summary>
    public class Responsable
    {
        /// <summary>
        /// login du responsable
        /// </summary>
        public string login { get; }
        //mot de passe du responsable
        public string pwd { get; }
        /// <summary>
        /// constructeur de la classe responsable et qui permet de remplir ses propriétés
        /// </summary>
        /// <param name="login">propriété login du responsable qui lui sert pour pouvoir se connecter au logiciel</param>
        /// <param name="pwd">propriété pwd du responsable qui lui sert à pouvoir se connecter</param>
        public Responsable (string login, string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }
    }
}
