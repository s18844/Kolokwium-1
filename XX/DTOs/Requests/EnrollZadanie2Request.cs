using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.DTOs.Requests
{
    public class EnrollZadanie2Request
    {
        [Required(ErrorMessage = "Musisz podać id Recepty")]
        [RegularExpression("[0-9]+$")]
        public string IdRecepty { get; set; }
        
    }
}
