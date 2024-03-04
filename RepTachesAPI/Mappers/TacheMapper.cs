using RepTachesAPI.API.DTOs.TacheDTO;
using RepTachesAPI.Domain.Models;
using System.Net.Sockets;


namespace RepTachesAPI.API.Mappers
{
    public static class TacheMapper
    {
        public static Tache DTOToDomain(this TacheFormDTO tache)
        {
            return new Tache
            {
                IdTache = 0,
                Description = tache.Description,
                NomTache = tache.NomTache,

            };
        }

        public static TacheViewModelDTO DomainToInfoDTO(this Tache tache)
        {
            return new TacheViewModelDTO
            {
                IdTache = tache.IdTache,
                NomTache = tache.NomTache,
                Recurrence = tache.Recurrence,
                Priorite = tache.Priorite,
                Description = tache.Description,
                DateDebut = tache.DateDebut,
                DateFin = tache.DateFin,
                DateEcheance = tache.DateEcheance,
                TachePartagee = tache.TachePartagee,
                Utilisateur = tache.Utilisateur,

            };
        }

    };
        

        //public static IEnumerable<TacheInfoDTO> DomainToInfoDTO(this IEnumerable<Tache> tache)
        //{
        //    List<TacheInfoDTOO> tacheInfoDTOs = new List<TacheInfoDTO>();
        //    foreach (Tache tache in tache)
        //    {
        //        tacheInfoDTOs.Add(tache.DomainToInfoDTO());
        //    }
        //    return (IEnumerable<TacheInfoDTO>)tacheInfoDTOs;
        //}
}
