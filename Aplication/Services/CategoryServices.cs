using StockApp.Core.Application.Interfaces.Repositories;
using StockApp.Core.Application.Interfaces.Services;
using StockApp.Core.Application.ViewModel.Categories;
using StockApp.Core.Domain.Entities;

namespace StockApp.Core.Application.Services
{
    public class CategoryServices : ICategoryServices
    {

        private readonly ICategoryRepository _categoryRepository;

        public CategoryServices(ICategoryRepository categoryRepository) 
        {
            _categoryRepository = categoryRepository;
        }

        public async Task addServices(SaveCategoryViewModel vm)
        {
            var category = new Categories();
            category.categoryName = vm.categoryName;
            category.categoryDescription = vm.categoryDescription;

            await _categoryRepository.addRepository(category);
        }

        public async Task updateServices(SaveCategoryViewModel vm)
        {
            var category = new Categories();
            category.id = vm.id;
            category.categoryName = vm.categoryName;
            category.categoryDescription = vm.categoryDescription;

            await _categoryRepository.updateRepository(category);
        }

        public async Task<SaveCategoryViewModel> getByIDservice(int id)
        {
            var category = await _categoryRepository.getByIdRepository(id);
            var vm = new SaveCategoryViewModel();

            vm.id = category.id;
            vm.categoryName = category.categoryName;
            vm.categoryDescription = category.categoryDescription;

            return vm;
        }

        public async Task deleteService(int id)
        {
            var category = await _categoryRepository.getByIdRepository(id);
            await _categoryRepository.deleteRepository(category);
        }

        public async Task<List<CategoryViewModel>> getAllservice()
        {
            var categories = await _categoryRepository.getAllRepository();

            return categories.Select(category => new CategoryViewModel
            {
                id = category.id,
                categoryName = category.categoryName,
                categoryDescription = category.categoryDescription
            }).ToList();
        }

        //TODO: null error in category.product.count
        public async Task<List<CategoryViewModel>> getAllWhitIncludesServices() 
        {
            var categories = await _categoryRepository.GetAllWhitIncluedeRepository(new List<string> { "Product" });

            return categories.Select(category => new CategoryViewModel
            {
                id = category.id,
                categoryName = category.categoryName,
                categoryDescription = category.categoryDescription,
                productsCount = category.products.Count()
            }).ToList();
        }
    }
}
