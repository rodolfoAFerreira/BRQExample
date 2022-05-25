using System;

namespace BRQExampleDomain.Entity.Extension
{
    public static class ExtensionExpired
    {
        public static string ValidExpired(this Category category)
        {
            if((DateTime.Now.AddDays(-30) > category.Trade.NextPaymentDate)) return "EXPIRED";

            return "";
        }
    }
}
