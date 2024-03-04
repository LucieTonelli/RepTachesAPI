using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepTachesAPI.Domain.Enums;
using System.Collections.Generic;

namespace RepTachesAPI.Domain.Models
{
    public class Tache
    {
        public int IdTache { get; set; }
        public string NomTache { get; set; }
        public int Statut { get; set; } = 1;
        public Enum Recurrence { get; set; } = RecurrenceTache.Non;
        public Enum Priorite { get; set; } = PrioriteTache.Faible;
        public string? Description { get; set; }

        public DateTime DateCreation { get; set; } = DateTime.Now;
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }

        public DateTime DateEcheance { get; set; }
        public bool TachePartagee { get; set; } = false;
        public bool EstComplete { get; set; } = false;

        public List<Utilisateur>? Utilisateur { get; set; }

    }

}