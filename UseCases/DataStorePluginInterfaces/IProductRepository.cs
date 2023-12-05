using CoreBussiness;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        void DeleteProduct(int productId);
        Product GetProductById(int productId);
        IEnumerable<Product> GetProducts();
        IEnumerable<Product> GetProductsByCategoryId(int categoryId);
        void UpdateProduct(Product product);
    }
}