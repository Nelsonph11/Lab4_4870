using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models;

    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required]
        [Display(Name = "City")]
        public string? CityName { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int? Population { get; set; }

        // Foreign key for Province
        [Display(Name = "Province Code")]
        public string? ProvinceCode { get; set; }

        [ForeignKey("ProvinceCode")]
        public Province? Province { get; set; }
    }
