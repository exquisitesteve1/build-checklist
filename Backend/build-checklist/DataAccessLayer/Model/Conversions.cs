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
        [Key]
        public int ConversionId { get; set; }
        [Required]
        [MaxLength(255)]
        public string ConversionName { get; set; }
        //[Required]
        //[MaxLength(255)]
        public string ConversionDescription { get; set; }
        [Required]
        public int IdMember1 { get; set; }
        public int IdMember2 { get; set; }
        public int IdMember3 { get; set; }
        public int IdMember4 { get; set; }
        public bool CompletedStatus { get; set; }
        public string Type { get; set; }
    }
}
