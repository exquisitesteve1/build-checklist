using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class ConversionsVM
    {
        public int ConversionId { get; set; }
        public string ConversionName { get; set; }
        public string ConversionDescription { get; set; }
        public int IdMember1 { get; set; }
        public int IdMember2 { get; set; }
        public int IdMember3 { get; set; }
        public int IdMember4 { get; set; }
        public bool CompletedStatus { get; set; }
        public string Type { get; set; }
    }
}
