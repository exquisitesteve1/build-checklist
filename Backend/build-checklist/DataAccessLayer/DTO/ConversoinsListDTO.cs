using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DTO
{
    public class ConversionsListDTO
    {
        public int ConversionId { get; set; }
        public string ConversoinName { get; set; }
        public string Description { get; set; }
        public int IdMember1 { get; set; }
        public int IdMember2 { get; set; }
        public int IdMember3 { get; set; }
        public int IdMember4 { get; set; }
        public bool CompletedStatus { get; set; }
        public string Type { get; set; }
    }
}
