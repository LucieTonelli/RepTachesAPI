using RepTachesAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepTachesAPI.DAL.Interfaces
{
    public interface IUtilisateurRepository
    {
        IEnumerable<Utilisateur> GetAll();
        Utilisateur? GetById(int id);
        Utilisateur? GetByEmail(string email);
        Utilisateur Create(Utilisateur Utilisateur);
        Utilisateur Update(Utilisateur Utilisateur);
        Utilisateur UpdateRole(Utilisateur utilisateur);
        bool Delete(int id);
    }
}
