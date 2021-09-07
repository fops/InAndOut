using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class Person
    {

        public int Id { get; set; }

        [Required]
        public string Eesnimi { get; set; }
        [Required]
        public string Perekonnanimi { get; set; }
        [Required]
        public int Isikukood { get; set; }
        [Required]
        public string Maksmine { get; set; }

        [Range(1, 1500, ErrorMessage = "Maksimaalselt 1500 tähemärki")]
        public string Lisainfo { get; set; }
        public Yritused UrituseId { get; set; }
    }
}

