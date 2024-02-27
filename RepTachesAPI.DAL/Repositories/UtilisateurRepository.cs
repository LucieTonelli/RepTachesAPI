using RepTachesAPI.DAL.Interfaces;
using RepTachesAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepTachesAPI.DAL.Repositories
{
    public class UtilisateurRepository : IUtilisateurRepository
    {
        public Utilisateur Create(Utilisateur Utilisateur)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Utilisateur> GetAll()
        {
            throw new NotImplementedException();
        }

        public Utilisateur? GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Utilisateur? GetById(int id)
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
