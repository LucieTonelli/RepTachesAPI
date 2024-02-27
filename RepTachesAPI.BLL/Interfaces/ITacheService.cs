using RepTachesAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepTachesAPI.BLL.Interfaces
{
    public interface ITacheService
    {


            IEnumerable<Tache> GetAll();
            Tache? GetById(int id);
            Tache Create(Tache tache);
            Tache? Update(Tache tache);
            Tache? Complete(Tache tache);
            bool Delete(int id);
    

    }
}
