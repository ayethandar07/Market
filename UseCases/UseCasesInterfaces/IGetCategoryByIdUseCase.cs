using CoreBussiness;

namespace UseCases.UseCasesInterfaces
{
    public interface IGetCategoryByIdUseCase
    {
        Category Execute(int categoryId);
    }
}