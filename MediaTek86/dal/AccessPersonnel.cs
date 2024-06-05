using System;
using System.Collections.Generic;
using MediaTek86.model;
using Serilog;
using MySql;

namespace MediaTek86.dal
{
    /// <summary>
    /// classe permettant de gérer les demandes liées au personnel
    /// </summary>
    public class AccessPersonnel
    {
        /// <summary>
        /// instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;
        /// <summary>
        /// constructeur pour créer l'accès aux données
        /// </summary>
        public AccessPersonnel()
        {
            access = Access.GetInstance();
        }
        /// <summary>
        /// controle qui détermine si le login et le mot de passe saisit sont correctes
        /// </summary>
        /// <returns>vrai si le login et le mot de passe saisit sont correctes</returns>
        public Boolean ControleConnexion(Responsable responsable)
        {
            if (access.Manager != null)
            {
                string req = "select * from responsable ";
                req += "where login=@login and pwd=@pwd;";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@login", responsable.login },
                    { "@pwd", responsable.pwd }
                };
                try
                {
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("AccessPersonnel.ControleConnexion catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return true;
        }
        /// <summary>
        /// récupère et retourne le personnel
        /// </summary>
        /// <returns>la liste du personnel</returns>
        public List<Personnel> GetLePersonnel()
        {
            List<Personnel> LePersonnel = new List<Personnel>();
            if (access.Manager != null)
            {
                string req = "select p.idpersonnel, p.nom, p.prenom, p.tel, p.mail, s.idservice, s.nom";
                req += "from personnel p join service s on (p.idservice = s.idservice)";
                req += "order by nom, prenom;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        Log.Debug("AccessPersonnel.GetLePersonnel nb records = {0}", records.Count);
                        foreach (Object[] record in records)
                        {
                            Log.Debug("AccessPersonnel.GetLePersonnel Service : id={0} nom={1}", record[5], record[6]);
                            Log.Debug("AccessPersonnel.GetLePersonnel Personnel : id={0} nom={1} prenom={2} tel={3} mail={4}", record[0], record[1], record[2], record[3], record[4]);
                            Service service = new Service((int)record[5], (string)record[6]);
                            Personnel personnel = new Personnel((int)record[0], (string)record[1], (string)record[2], (string)record[3], (string)record[4], service);
                            LePersonnel.Add(personnel);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("AccessPersonnel.GetLePersonnel catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return LePersonnel;
        }
        /// <summary>
        /// permet la suppression d'un membre du personnel
        /// </summary>
        /// <param name="personnel">objet de type personnel</param>
        public void DelPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "delete from personnel where idpersonne = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        {"@idpersonnel", personnel.idpersonnel }
                    };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("AccessPersonnel.DelPersonnel catch req={0} erreur{1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }
        /// <summary>
        /// permet l'ajout d'un nouveau membre dans le personnel
        /// </summary>
        /// <param name="personnel">objet de type personnel</param>
        public void AddPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "insert into personnel(nom, prenom, tel, mail, idservice)";
                req += "values (@nom, @prenom, @tel, @mail, @idservice;";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@nom", personnel.nom },
                    { "@prenom", personnel.prenom },
                    { "@tel", personnel.tel },
                    { "@mail", personnel.mail },
                    { "@idservice", personnel.service.idservice }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("AccessPersonnel.AddPersonnel catch req={0} error{1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }
        /// <summary>
        /// permet la modification des infos d'un membre du personnel
        /// </summary>
        /// <param name="personnel">objet de type personnel</param>
        public void UpdatePersonnel (Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "update personnel set nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice";
                req += "where idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "idpersonnel", personnel.idpersonnel },
                    { "nom", personnel.nom },
                    { "prenom", personnel.prenom },
                    { "tel", personnel.tel },
                    { "mail", personnel.mail },
                    { "idservice", personnel.service.idservice }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("AccessPersonnel.UpdatePersonnel catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }

    }
}
