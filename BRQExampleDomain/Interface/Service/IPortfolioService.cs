using BRQExampleDomain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BRQExampleDomain.Interface.Service
{
    public interface IPortfolioService
    {
        Task<string> getDateReference(string date);
        Task<string> getPortfolioId(string id);
        Task<string> getTrade(string value);
        Task<List<Trade>> getTrades();
    }
}
