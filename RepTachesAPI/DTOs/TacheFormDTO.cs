using System.ComponentModel.DataAnnotations;

namespace RepTachesAPI.API.DTOs
{
    public class TacheFormDTO
    {

        [Required(ErrorMessage = "Le champs Titre est requis")]
        [MaxLength(50, ErrorMessage = "Le champs Titre doit faire maximum 50 caractères")]
        public string NomTache { get; set; }

        [MaxLength(200, ErrorMessage = "Le champs Description doit faire maximum 200 caractères")]
        public string? Description { get; set; }
    }
}
