using BRQExampleDomain.Entity;
using BRQExampleDomain.Entity.Extension;
using BRQExampleDomain.Interface.Service;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRQExampleDomain.Service
{
    public class CategoryService : ICategoryService
    {
        public Category category;

        public CategoryService()
        {
            category = new Category();
        }

        public async Task<string> ValidCategory(List<Trade> trades)
        {
            var validCategory = new List<string>();
            trades.ForEach(trade =>
            {
                category.Trade = trade;

                validCategory.Add(category.ValidExpired());
                validCategory.Add(category.ValidMediumRisk());
                validCategory.Add(category.ValidHighRisk());
            });

            var c = validCategory.RemoveAll(trade => trade == "");

            return await Task.FromResult(validCategory.FirstOrDefault() ?? "");
        }
    }
}
