using Microsoft.Extensions.Configuration;
using RepTachesAPI.BLL.Interfaces;
using RepTachesAPI.DAL.Interfaces;
using RepTachesAPI.DAL.Tools;
using RepTachesAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Tools.CustomExceptions;

namespace RepTachesAPI.BLL.Services
{
    public class TacheService : ITacheService
    {
        private readonly ITacheRepository _repository;
        private IConnection _connection;


        public TacheService(ITacheRepository repository)
        {
            _repository = repository;
        }

        public Tache? Complete(int IdTache)
        {
            Tache? tacheToUpdate = _repository.GetById(IdTache);
            if (tacheToUpdate is null)
            {
                throw new NotFoundException($"Le ticket {IdTache} n'a pas été trouvé");
            }

            tacheToUpdate.DateFin = DateTime.Now;
            tacheToUpdate.EstComplete = true;

            return _repository.Complete(tacheToUpdate);
        }

        public Tache Create(Tache tache)
        {
            return _repository.Create(tache);
        }






        public Tache? Complete(Tache tache)
        {
            return _repository.Create(tache);
        }

        public Tache Create(Tache tache)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tache> GetAll()
        {
            throw new NotImplementedException();
        }


        public Tache GetById(object idTache)
        {
            throw new NotImplementedException();
        }

        public Tache? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Tache? Update(Tache tache)
        {
            throw new NotImplementedException();
        }
    }
}
