using CoreBussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCasesInterfaces;

namespace UseCases.CategoryUseCases
{
    public class ViewCategoriesUseCase : IViewCategoriesUseCase
    {
        private readonly ICategoryRepository categoriesRepository;
        public ViewCategoriesUseCase(ICategoryRepository categoriesRepository)
        {
            this.categoriesRepository = categoriesRepository;
        }

        public IEnumerable<Category> Execute()
        {
            return categoriesRepository.GetCategories();
        }
    }
}
