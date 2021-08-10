using HSPXL2.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HSPXL2.Models
{
    public class InschrijvingDto
    {
        [Key]
        public int InschrijvingID { get; set; }

        [Required]
        public long StudentID { get; set; }
        public Student Student { get; set; }

        [Required]
        public long CursusID { get; set; }
        public Cursus Cursus { get; set; }

        public SelectList CursusList { get; set; }
        public SelectList StudentList { get; set; }
    }
}
