using RepTachesAPI.BLL.Interfaces;
using RepTachesAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepTachesAPI.BLL.Services
{
    public class UtilisateurService : IUtilisateurService
    {
        Utilisateur IUtilisateurService.Create(Utilisateur Utilisateur)
        {
            throw new NotImplementedException();
        }

        bool IUtilisateurService.Desactiver(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Utilisateur> IUtilisateurService.GetAll()
        {
            throw new NotImplementedException();
        }

        Utilisateur? IUtilisateurService.GetById(int id)
        {
            throw new NotImplementedException();
        }

        Utilisateur? IUtilisateurService.RapportTache(int id)
        {
            throw new NotImplementedException();
        }

        Utilisateur IUtilisateurService.Update(Utilisateur Utilisateur)
        {
            throw new NotImplementedException();
        }

        Utilisateur IUtilisateurService.UpdateRole(Utilisateur utilisateur)
        {
            throw new NotImplementedException();
        }
    }
}
