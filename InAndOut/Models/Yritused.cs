using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class Yritused
    {

        public int Id { get; set; }

        [Required]
        public string YritusName { get; set; }

        [Required]
      
        public DateTime Aeg { get; set; }
        public string Place { get; set; }





    }
}
