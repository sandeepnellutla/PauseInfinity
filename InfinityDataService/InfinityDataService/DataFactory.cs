using InfinityDataService.Dal;
using InfinityDataService.Model;
using System.Collections.Generic;

namespace InfinityDataService
{
    public static class DataFactory
    {
        static CategoryDataFactory categoryDataFactory = new CategoryDataFactory();

        public static List<Category> GetCategories()=> categoryDataFactory.GetCategories();

        public static Category GetCategoryById(int id) => categoryDataFactory.GetCategoryById(id);
    }
}