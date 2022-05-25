using BRQExampleApplication.Interface;
using BRQExampleApplication.ViewModel;
using BRQExampleDomain.Interface.Service;
using System.Collections.Generic;
using System.Threading.Tasks;
using BRQExampleApplication.Mapper;

namespace BRQExampleApplication
{
    public class PortfolioAppService : IPortfolioAppService
    {
        private readonly IPortfolioService _portfolioService;
        public PortfolioAppService(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public async Task<string> getDateReference(string date)
        {
            return await _portfolioService.getDateReference(date);
        }

        public async Task<string> getPortfolioId(string id)
        {
            return await _portfolioService.getPortfolioId(id);
        }

        public async Task<string> getTrade(string line)
        {
            return await _portfolioService.getTrade(line);
        }

        public async Task<List<TradeViewModel>> getTrades()
        {
            return DomainToViewModel.DomainToViewModelMapper(await _portfolioService.getTrades());
        }
    }
}
