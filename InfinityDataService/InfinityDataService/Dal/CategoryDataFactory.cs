using System;
using System.Collections.Generic;
using System.Linq;
using InfinityDataService.Model;
using System.Data;
using Dapper;

namespace InfinityDataService.Dal
{
    public class CategoryDataFactory : ICategoryDataFactory
    {
        static DataConnection conn = new DataConnection();
        public int Add(Category _category)
        {
            using (IDbConnection db = conn.GetConnection())
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                }

                var dynamicParams = new
                {
                    Name = _category.Name,
                    UrlSlug = _category.UrlSlug,
                    Description = _category.Description
                };

                var returnResult = db.Execute(SqlQueryConstants.SqlCreateCategory, dynamicParams);
                return returnResult;
            }
        }

        public int Delete(Category _category)
        {
            using (IDbConnection db = conn.GetConnection())
            {
                var dynamicParams = new
                {
                    CategoryId = _category.CategoryId,
                };

                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                }

                return db.Execute(SqlQueryConstants.SqlDeleteCategory, dynamicParams);
            }
        }

        public List<Category> GetCategories()
        {
            using (IDbConnection db = conn.GetConnection())
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                }

                return db.Query<Category>(SqlQueryConstants.SqlGetAllCategories).ToList();
            }
        }

        public Category GetCategoryById(int id)
        {
            using (IDbConnection db = conn.GetConnection())
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                }

                return db.Query<Category>(SqlQueryConstants.SqlGetCategoriesById, new { CategoryId = id }).FirstOrDefault();
            }
        }

        public int Update(Category _category)
        {
            using (IDbConnection db = conn.GetConnection())
            {
                var dynamicParams = new
                {
                    CategoryId = _category.CategoryId,
                    Name = _category.Name,
                    UrlSlug = _category.UrlSlug,
                    Description = _category.Description
                };

                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                }

                return db.Execute(SqlQueryConstants.SqlUpdateCategory, dynamicParams);
            }
        }
    }
}