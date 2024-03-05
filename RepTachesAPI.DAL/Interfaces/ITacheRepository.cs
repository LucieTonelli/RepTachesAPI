using RepTachesAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RepTachesAPI.DAL.Interfaces
{
    public interface ITacheRepository
    {

        IEnumerable<Tache> GetAll();
        Tache? GetById(int id);
        Tache Create(Tache tache);
        Tache? Update(Tache tache);
        Tache? UpdateComplete(Tache tache);
        Tache? UpdatePriorite(Tache tache);
        Tache? AddUtilisateurs(int tacheId, List<int> utilisateurIds);
        bool Delete(int id);
    }
}
