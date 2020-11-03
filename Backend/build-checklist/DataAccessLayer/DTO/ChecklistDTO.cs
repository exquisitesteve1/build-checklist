using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DTO
{
    public class ChecklistDTO
    {
        public int EntryId { get; set; }
        public int ConversionId { get; set }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public bool CompletedStatus { get; set; }
        public int StepNo { get; set; }
    }
}
