using CoreBussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MarketContext db;
        public CategoryRepository(MarketContext db)
        {
            this.db = db;
        }

        public IEnumerable<Category> GetCategories()
        {
            return db.Categories.ToList();
        }

        public void AddCategory(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            var cat = db.Categories.Find(category.CategoryId);
            cat.Name = category.Name;
            cat.Description = category.Description;
            db.SaveChanges();
        }

        public Category GetCategoryById(int categoryId)
        {
            return db.Categories.Find(categoryId);
        }

        public void DeleteCategory(int categoryId)
        {
            var category = db.Categories.Find(categoryId);
            if (category == null) { return; }

            db.Categories.Remove(category);
            db.SaveChanges();
        }
    }
}
