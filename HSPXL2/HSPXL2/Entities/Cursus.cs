using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HSPXL2.Entities
{
    public class Cursus
    {
        [Key]
        public long CursusID { get; set; }

        [Required(ErrorMessage = "Vul u de Cursus Name in.")]
        public string CursusName { get; set; }

        [Required(ErrorMessage = "Vul de Studiepunten voor het vak in.")]
        public int Studiepunten { get; set; }


        public int HandboekID { get; set; }
        public Handboek handboek { get; set; }
        public ICollection<Handboek> HandBoeken { get; set; }
    }
}
