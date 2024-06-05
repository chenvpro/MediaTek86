using System;
using System.Collections.Generic;
using Serilog;
using MediaTek86.model;

namespace MediaTek86.dal
{
    /// <summary>
    /// classe permettant les demandes liés aux services
    /// </summary>
    public class AccessService
    {
        /// <summary>
        /// instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;
        /// <summary>
        /// constructeur pour créer l'accès aux données
        /// </summary>
        public AccessService()
        {
            access = Access.GetInstance();
        }
        /// <summary>
        /// récupère et retourne les services
        /// </summary>
        /// <returns>liste des services</returns>
        public List<Service> GetLesServices()
        {
            List<Service> lesServices = new List<Service>();
            if (access.Manager != null)
            {
                string req = "select * from service order by nom;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        Log.Debug("AccessService.GetLesService nb records = {0}", records.Count);
                        foreach (Object[] record in records)
                        {
                            Log.Debug("AccessService.GetLesServices id={0} nom={1}", record[0], record[1]);
                            Service service = new Service((int)record[0], (string)record[1]);
                            lesServices.Add(service);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("AccessService.GetLesServices catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return lesServices;
        }
    }
}
