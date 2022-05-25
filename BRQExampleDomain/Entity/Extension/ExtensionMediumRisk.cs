namespace BRQExampleDomain.Entity.Extension
{
    public static class ExtensionMediumRisk
    {
        public static string ValidMediumRisk(this Category category)
        {
            if (category.Trade.Value > 1000000 && category.Trade.ClientSector.ToLower() != "public") return "MEDIUMRISK";

            return "";
        }
    }
}
