using System.ComponentModel.DataAnnotations;

namespace RepTachesAPI.API.DTOs.UtilisateurDTO
{
    public class UtilisateurConnectViewModelDTO
    {
        [Required(ErrorMessage = "Le nom d'utilisateur est requis.")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Le mot de passe est requis.")]
        public string Passeword { get; set; }
    }
}
