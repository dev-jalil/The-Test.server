
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TheTest.Server.Data.Enumerations;

namespace TheTest.Server.Data.Models
{
    public class Personne
    {
        public int Id { get; set; }

        [Required]
        public string Prenom { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public string Email { get; set; }

        public string Note { get; set; }

        public DepartementType? DepartementType { get; set; }

        [Required]
        public DateTime? DateDeNaissance { get; set; }


    }
}
