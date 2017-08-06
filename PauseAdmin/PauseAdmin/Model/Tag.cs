using System;
using System.Collections.Generic;

namespace PauseAdmin.Models
{
    public partial class Tag
    {
        public int TagId { get; set; }
        public string Name { get; set; }
        public string UrlSlug { get; set; }
        public string Description { get; set; }
    }
}
