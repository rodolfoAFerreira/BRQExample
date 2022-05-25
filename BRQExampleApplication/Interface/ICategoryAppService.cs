using BRQExampleApplication.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BRQExampleApplication.Interface
{
    public interface ICategoryAppService
    {
        Task<string> ValidCategory(List<TradeViewModel> trades);
    }
}
