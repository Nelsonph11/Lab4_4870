using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models;

    public class Province
    {
        [Key]
        [Required]
        [Display(Name = "Province Code")]
        public string? ProvinceCode { get; set; }

        [Required]
        [Display(Name = "Province")]
        public string? ProvinceName { get; set; }

        // Navigation property for related Cities
        public ICollection<City>? Cities { get; set; }
    }
