using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HSPXL2.Entities
{
    public class Handboek
    {
        [Key]
        public int HandboekID { get; set; }

        [Required(ErrorMessage = "Vul u de boek Titel in.")]
        [StringLength(200)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Vul u de pijs in.")]
        [Column(TypeName = "decimal(8,2)")]
        public decimal KostPrijs { get; set; }

        [Required(ErrorMessage = "Geef de uitgift Datum van de boek.")]
        public DateTime UitgiftDatum { get; set; }

        public string Afbeelding { get; set; }

        public DateTime? CreationDate { get; set; }
    }
}
