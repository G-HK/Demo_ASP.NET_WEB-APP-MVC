using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HSPXL2.Entities
{
    public class Inschrijving
    {

        [Key]
        public int InschrijvingID { get; set; }

        [Required]
        public long StudentID { get; set; }
        public Student Student { get; set; }

        [Required]
        public long CursusID { get; set; }
        public Cursus Cursus { get; set; }
    }
}
