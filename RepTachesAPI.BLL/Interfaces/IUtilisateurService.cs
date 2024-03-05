using RepTachesAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepTachesAPI.BLL.Interfaces
{
    public interface IUtilisateurService
    {
        IEnumerable<Utilisateur> GetAll();
        Utilisateur? GetById(int id);
        Utilisateur? RapportTache(int id);
        Utilisateur Create(Utilisateur Utilisateur);
        Utilisateur Update(Utilisateur Utilisateur);
        Utilisateur UpdateRole(Utilisateur utilisateur);
        bool Desactiver(int id);
    }
}
