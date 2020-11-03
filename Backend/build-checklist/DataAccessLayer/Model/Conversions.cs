using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Conversions
    {
        public int ConversionId { get; set; }
        [Required]
        [MaxLength(255)]
        public string ConversionName { get; set; }
        [Required]
        [MaxLength(255)]
        public string ConversionDescription { get; set; }
        [Required]
        [MaxLength(255)]
        public string Member1 { get; set; }
        [MaxLength(255)]
        public string Member2 { get; set; }
        [MaxLength(255)]
        public string Member3 { get; set; }
        [MaxLength(255)]
        public string Member4 { get; set; }
        public bool CompletedStatus { get; set; }
        public string Type { get; set; }
    }
}
