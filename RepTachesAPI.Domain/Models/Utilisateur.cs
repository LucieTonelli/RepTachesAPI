using RepTachesAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepTachesAPI.Domain.Models
{
    public class Utilisateur
    {
        public int IdUtilisateur { get; set; }
        public string Username { get; set; }
        public Enum Role { get; set; } = RoleUtilisateur.Standard;
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string? Email { get; set; }

        public int Telephone { get; set; }
        public string Passeword { get; set; }

        public DateTime DateDerniereConnexion { get; set; }
        public List<Tache>? Tache { get; set; }
    }
}
