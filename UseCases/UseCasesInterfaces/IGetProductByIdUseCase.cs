using CoreBussiness;

namespace UseCases.UseCasesInterfaces
{
    public interface IGetProductByIdUseCase
    {
        Product Execute(int productId);
    }
}