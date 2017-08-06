using System;
using System.Collections.Generic;

namespace PauseAdmin.Models
{
    public partial class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public DateTime PostedOn { get; set; }
        public DateTime PublishedOn { get; set; }
        public string Meta { get; set; }

        public virtual Comment Comment { get; set; }
    }
}
