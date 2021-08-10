using HSPXL2.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HSPXL2.Models
{
    public class StudentIndex
    {
        [Key]
        public long StudentID { get; set; }

        [Required(ErrorMessage = "Vul u naam in.")]
        [StringLength(30)]
        public string Naam { get; set; }

        [Required(ErrorMessage = "Vul u Voornaam in.")]
        [StringLength(30)]
        public string Voornaam { get; set; }


        [Required(ErrorMessage = "Vul u je E-mail address in.")]
        [StringLength(255)]
        public string Email { get; set; }

        public DateTime CreationDate { get; set; }

        public Inschrijving Inschrijvings { get; set; }
        public List<Cursus> Cursus { get; set; }
    }
}
