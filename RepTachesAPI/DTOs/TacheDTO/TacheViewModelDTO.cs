using RepTachesAPI.Domain.Enums;
using RepTachesAPI.Domain.Models;

namespace RepTachesAPI.API.DTOs.TacheDTO
{
    public class TacheViewModelDTO
    {
        public int IdTache { get; set; }
        public string NomTache { get; set; }
        public Enum Recurrence { get; set; }
        public Enum Priorite { get; set; }
        public string Description { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }

        public DateTime DateEcheance { get; set; }
        public bool TachePartagee { get; set; } = false;
        public List<Utilisateur>? Utilisateurs { get; set; }


    }
}
