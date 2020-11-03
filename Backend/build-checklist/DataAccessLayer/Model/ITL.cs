using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class ITL
    {
        public int EntryId { get; set; }
        [Required]
        public int ConversionId { get; set; }
        [Required]
        [MaxLength(255)]
        public string TaskName { get; set; }
        [MaxLength(255)]
        public string TaskDescription { get; set; }
        [Required]
        public bool CompletedStatus { get; set; }
        [MaxLength(255)]
        public int StepNo { get; set; }
    }
}
