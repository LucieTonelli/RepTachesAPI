using RepTachesAPI.Domain.Enums;
using RepTachesAPI.Domain.Models;
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


        public RecurrenceTache Recurrence { get; set; } = RecurrenceTache.Non;
        public PrioriteTache Priorite { get; set; } = PrioriteTache.Moyenne;
        
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //public DateTime DateEcheance { get; set; }

        [DefaultValue(false)]
        public bool TachePartagee { get; set; } = false;

        //public Utilisateur IdUtilisateur { get; set; }


        //        var tache = new TacheFormDTO();
        //        tache.Utilisateurs.Add("Utilisateur1");
        //tache.Utilisateurs.Add("Utilisateur2");
        //tache.Utilisateurs.Remove("Utilisateur2");
    }

}

