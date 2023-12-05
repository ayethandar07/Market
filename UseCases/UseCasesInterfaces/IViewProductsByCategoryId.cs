using CoreBussiness;

namespace UseCases.UseCasesInterfaces
{
    public interface IViewProductsByCategoryId
    {
        IEnumerable<Product> Execute(int categoryId);
    }
}