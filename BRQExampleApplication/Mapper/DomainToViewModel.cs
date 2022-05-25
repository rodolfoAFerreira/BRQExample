using BRQExampleApplication.ViewModel;
using BRQExampleDomain.Entity;
using System.Collections.Generic;

namespace BRQExampleApplication.Mapper
{
    public static class DomainToViewModel
    {
        //---------------------------------
        //However is better use AutoMapper
        //---------------------------------

        public static List<TradeViewModel> DomainToViewModelMapper(List<Trade> listTrades = null)
        {
            if (listTrades != null)
            {
                var tradesViewModel = new List<TradeViewModel>();

                foreach (var trade in listTrades)
                {
                    tradesViewModel.Add(new TradeViewModel()
                    {
                        ClientSector = trade.ClientSector,
                        NextPaymentDate = trade.NextPaymentDate,
                        Value = trade.Value
                    });
                }

                return tradesViewModel;
            }

            return new List<TradeViewModel>();
        }

    }
}

