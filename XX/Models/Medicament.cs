using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Models
{
    public class Medicament
    {
        public string IndexNumber { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public DateTime Birthdate { get; set; }
        //prop + tabx2
        public string Studies { get; set; }
        public int Semester { get; set; }

        //...
        //...
    }
}
