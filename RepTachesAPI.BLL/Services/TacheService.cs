using RepTachesAPI.BLL.Interfaces;
using RepTachesAPI.DAL.Interfaces;
using RepTachesAPI.Domain.Models;

namespace RepTachesAPI.BLL.Services
{
    public class TacheService : ITacheService
    {

        private readonly ITacheRepository _repository;

        public TacheService(ITacheRepository repository)
        {
            _repository = repository;
        }

        Tache? ITacheService.AddUtilisateurs(int tacheId, List<int> utilisateurIds)
        {
            throw new NotImplementedException();
        }

        Tache ITacheService.Create(Tache tache)
        {
            return _repository.Create(tache);
        }

        bool ITacheService.Delete(int id)
        {
            return _repository.Delete(id);
        }

        IEnumerable<Tache> ITacheService.GetAll()
        {
            throw new NotImplementedException();
        }

        Tache? ITacheService.GetById(int id)
        {
            throw new NotImplementedException();
        }

        Tache? ITacheService.Update(Tache tache)
        {
            throw new NotImplementedException();
        }

        Tache? ITacheService.UpdateComplete(Tache tache)
        {
            throw new NotImplementedException();
        }

        Tache? ITacheService.UpdatePriorite(Tache tache)
        {
            throw new NotImplementedException();
        }

    }
}
