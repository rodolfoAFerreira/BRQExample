using BRQExampleDomain.Interface.Service;
using BRQExampleDomain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Globalization;

namespace BRQExample.Service
{
    public class PortfolioService : IPortfolioService
    {
        public Portfolio portfolio;
        public PortfolioService()
        {
            portfolio = new Portfolio();
        }

        public async Task<string> getDateReference(string date)
        {
            DateTime temp;
            if (!DateTime.TryParseExact(date, "MM/dd/yyyy", new CultureInfo("en-US"), DateTimeStyles.None, out temp))
            {
                return await Task.FromResult("Date not valid");
            }

            portfolio.DateReference = DateTime.ParseExact(date, "MM/dd/yyyy", new CultureInfo("en-US"));

            return await Task.FromResult("");
        }

        public async Task<string> getPortfolioId(string id)
        {
            int temp;
            if (!int.TryParse(id, out temp))
            {
                return await Task.FromResult("Portfolio not valid");
            }

            portfolio.PortfolioId = int.Parse(id);

            return await Task.FromResult("");
        }

        public async Task<string> getTrade(string line)
        {
            var arrayline = line.Split(" ");
            if (arrayline.Length < 3)
            {
                return "Invalid format";
            }

            var value = arrayline[0];
            var sector = arrayline[1];
            var pendingPayment = arrayline[2];

            portfolio.Trades = new List<Trade>();

            double tempValue;
            if (!double.TryParse(value, out tempValue))
            {
                return await Task.FromResult("Value is not valid");
            }

            if (!Sector.ValidSector(sector))
            {
                return await Task.FromResult("Sector is not valid");
            }

            DateTime tempPendingPayment;
            if (!DateTime.TryParseExact(pendingPayment, "MM/dd/yyyy", new CultureInfo("en-US"), DateTimeStyles.None, out tempPendingPayment))
            {
                return await Task.FromResult("Date not valid");
            }

            portfolio.Trades.Add(new Trade()
            {
                Value = tempValue,
                ClientSector = sector,
                NextPaymentDate = tempPendingPayment
            });

            return await Task.FromResult("");
        }
        

        public async Task<List<Trade>> getTrades() => await Task.FromResult(portfolio.Trades);



    }
}
