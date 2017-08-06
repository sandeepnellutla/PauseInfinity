using System;
using System.Collections.Generic;

namespace PauseAdmin.Models
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public string Description { get; set; }
        public int BlogId { get; set; }
        public DateTime PostedOn { get; set; }

        public virtual Blog CommentNavigation { get; set; }
    }
}
