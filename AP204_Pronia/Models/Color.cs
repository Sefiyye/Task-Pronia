using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AP204_Pronia.Models
{
    public class Color
    {
        public int Id { get; set; }

        [StringLength(maximumLength: 10, ErrorMessage = "You can write maximum 10 charachter")]
        public string Name { get; set; }
        public List<Plant> Plants { get; set; }
    }
}
