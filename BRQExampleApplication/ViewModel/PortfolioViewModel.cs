using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRQExampleApplication.ViewModel
{
    public class PortfolioViewModel
    {
        public int PortfolioId { get; set; }
        public DateTime DateReference { get; set; }
        public List<TradeViewModel> Trades { get; set; }
    }
}
