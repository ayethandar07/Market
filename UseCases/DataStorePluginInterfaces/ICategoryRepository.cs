using CoreBussiness;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ICategoryRepository
    {
        void AddCategory(Category category);
        IEnumerable<Category> GetCategories();
        void UpdateCategory(Category category);
        Category GetCategoryById(int categoryId);
        void DeleteCategory(int categoryId);
    }
}