using StockApp.Core.Application.ViewModel.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Core.Application.Interfaces.Services
{
    public interface ICategoryServices
    {
        public Task addServices(SaveCategoryViewModel vm);
        public Task updateServices(SaveCategoryViewModel vm);
        public Task<SaveCategoryViewModel> getByIDservice(int id);
        public Task deleteService(int id);
        public Task<List<CategoryViewModel>> getAllservice();
        public Task<List<CategoryViewModel>> getAllWhitIncludesServices();
    }
}
