using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleTours.Shared.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public bool IsPublic { get; set; } = false;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? CreatedApproved { get; set; }
        public string Heading { get; set; }
        public string CommentText { get; set; }
    }
}
