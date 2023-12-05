using CoreBussiness;

namespace UseCases.UseCasesInterfaces
{
    public interface IViewCategoriesUseCase
    {
        IEnumerable<Category> Execute();
    }
}