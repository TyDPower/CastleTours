using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CastleTours.Shared.Models
{
    public class CastleComment : Comment
    {
        public int CastleId { get; set; }
        [JsonIgnore]
        public Castle Castle { get; set; }
    }
}
