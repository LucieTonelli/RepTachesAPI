using RepTachesAPI.Domain.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RepTachesAPI.API.DTOs.TacheDTO
{
    public class TacheFormDTO
    {

        [Required(ErrorMessage = "Le champs Titre est requis")]
        [MaxLength(50, ErrorMessage = "Le champs Titre doit faire maximum 50 caractères")]
        public string NomTache { get; set; }

        [MaxLength(200, ErrorMessage = "Le champs Description doit faire maximum 200 caractères")]
        public string? Description { get; set; }


        public Enum Recurrence { get; set; } = RecurrenceTache.Non;
        public Enum Priorite { get; set; } = PrioriteTache.Moyenne;

        public DateTime DateEcheance { get; set; }

        [DefaultValue(false)]
        public bool TachePartagee { get; set; } = false;

        public string? Utilisateur { get; set; }
    }


}

