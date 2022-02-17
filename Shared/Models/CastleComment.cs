using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleTours.Shared.Models
{
    public class CastleComment : Comment
    {
        public int CastleId { get; set; }
        public Castle Castle { get; set; }
    }
}
