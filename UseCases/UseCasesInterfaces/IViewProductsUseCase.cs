using CoreBussiness;

namespace UseCases.UseCasesInterfaces
{
    public interface IViewProductsUseCase
    {
        IEnumerable<Product> Execute();
    }
}