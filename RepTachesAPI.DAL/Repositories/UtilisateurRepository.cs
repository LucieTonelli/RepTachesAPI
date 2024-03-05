using RepTachesAPI.DAL.Interfaces;
using RepTachesAPI.Domain.Models;

namespace RepTachesAPI.DAL.Repositories
{
    public class UtilisateurRepository : IUtilisateurRepository

    {
        
        public Utilisateur Create(Utilisateur Utilisateur)
        {
            throw new NotImplementedException();
        }

        public bool Desactiver(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Utilisateur> GetAll()
        {
            throw new NotImplementedException();
        }

        public Utilisateur? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Utilisateur? RapportTache(int id)
        {
            throw new NotImplementedException();
        }

        public Utilisateur Update(Utilisateur Utilisateur)
        {
            throw new NotImplementedException();
        }

        public Utilisateur UpdateRole(Utilisateur utilisateur)
        {
            throw new NotImplementedException();
        }
    }
}
