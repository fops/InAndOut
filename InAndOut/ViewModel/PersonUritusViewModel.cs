using InAndOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.ViewModel
{
    public class PersonUritusViewModel
    {
        public Yritused GetYritused { get; set; }
        public Person GetPerson { get; set; }

        public IEnumerable<Yritused> yritused { get; set; }
        public IEnumerable<Person> people { get; set; }
    }
}
