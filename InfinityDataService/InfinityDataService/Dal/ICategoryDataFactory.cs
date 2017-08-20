using InfinityDataService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfinityDataService.Dal
{
    public interface ICategoryDataFactory
    {
        List<Category> GetCategories();
        Category GetCategoryById(int id);
        int Add(Category _category);
        int Update(Category _category);
        int Delete(Category _category);
    }
}
