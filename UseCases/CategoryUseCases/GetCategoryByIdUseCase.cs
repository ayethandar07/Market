﻿using CoreBussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCasesInterfaces;

namespace UseCases.CategoryUseCases
{
    public class GetCategoryByIdUseCase : IGetCategoryByIdUseCase
    {
        private readonly ICategoryRepository categoryRepository;

        public GetCategoryByIdUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public Category Execute(int categoryId)
        {
            return categoryRepository.GetCategoryById(categoryId);
        }
    }
}
