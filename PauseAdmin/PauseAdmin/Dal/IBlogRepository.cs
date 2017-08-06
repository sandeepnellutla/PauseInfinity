using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PauseAdmin.Dal
{
    public interface IBlogRepository
    {
        void GetAllBlogs();

        void GetBlogById();
        
    }
}
