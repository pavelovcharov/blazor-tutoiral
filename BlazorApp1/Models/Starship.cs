using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models {
    public class Starship {
        [Required]
        [StringLength(16, ErrorMessage ="Idenfier too long (16 charcter limit).")]
        public string Identifier { get; set; }

        public string Description { get; set; }

        [Required]
        public string Classification { get; set; }

        [Range(1, 1000, ErrorMessage = "Accommodation invalid (1 - 1000).")]
        public int MaximumAccommodation { get; set; }

        [Required]
        [Range(typeof(bool), "true", "true", ErrorMessage ="This form disallows unapproved ships.")]
        public bool IsValidedDesign { get; set; }

        [Required]
        public DateTime ProductionDate { get; set; }
    }
}
