using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Herhaling1.ViewModels
{
    public class StudentBasic
    {

        [Display(Name = "student Nummer")]
        public int Studnr { get; set; }

        [Display(Name ="Naam")]
        public string Voornaam { get; set; }
        [Display(Name = "Famillienaam")]
        public string Familienaam { get; set; }
    }
}
