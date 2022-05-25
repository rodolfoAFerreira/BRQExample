using BRQExampleApplication.Interface;
using BRQExampleApplication.Mapper;
using BRQExampleApplication.ViewModel;
using BRQExampleDomain.Interface.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BRQExampleApplication
{
    public class CategoryAppService : ICategoryAppService
    {
        private readonly ICategoryService _categoryService;
        public CategoryAppService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<string> ValidCategory(List<TradeViewModel> trades)
        {
            var listTrade = ViewModelToDomain.ViewModelToDomainMapper(trades);

            return await _categoryService.ValidCategory(listTrade);
        }
    }
}
