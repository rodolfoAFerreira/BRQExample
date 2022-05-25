using BRQExampleApplication.ViewModel;
using BRQExampleDomain.Entity;
using System.Collections.Generic;

namespace BRQExampleApplication.Mapper
{
    public static class ViewModelToDomain
    {
        //---------------------------------
        //However is better use AutoMapper
        //---------------------------------

        public static List<Trade> ViewModelToDomainMapper(List<TradeViewModel> listTradesViewModel = null)
        {
            if(listTradesViewModel != null)
            {
                var trades = new List<Trade>();

                foreach (var tradeViewModel in listTradesViewModel)
                {
                    trades.Add(new Trade()
                    {
                        ClientSector = tradeViewModel.ClientSector,
                        NextPaymentDate = tradeViewModel.NextPaymentDate,
                        Value = tradeViewModel.Value
                    });
                }

                return trades;
            }

            return new List<Trade>();
        }
    }
}
