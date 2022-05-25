using System;
using System.Collections.Generic;

namespace BRQExampleDomain.Entity
{
    public class Portfolio
    {
        public int PortfolioId { get; set; }
        public DateTime DateReference { get; set; }
        public List<Trade> Trades { get; set; }
    }
}
