namespace BRQExampleDomain.Entity.Extension
{
    public static class ExtensionHighRisk
    {
        public static string ValidHighRisk(this Category category)
        {
            if (category.Trade.Value > 1000000 && category.Trade.ClientSector.ToLower() != "private") return "HIGHRISK";

            return "";
        }
    }
}
