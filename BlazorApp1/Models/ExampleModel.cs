using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models {
    public class ExampleModel {
        [Required]
        [StringLength(10, ErrorMessage ="Name is tool long.")]
        public string Name { get; set; }
    }
}
