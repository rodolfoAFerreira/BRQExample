using BRQExampleApplication.ViewModel;
using BRQExampleDomain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BRQExampleApplication.Interface
{
    public interface IPortfolioAppService
    {
        Task<string> getDateReference(string date);
        Task<string> getPortfolioId(string id);
        Task<string> getTrade(string line);
        Task<List<TradeViewModel>> getTrades();
    }
}
