using System.Collections.Generic;

namespace BRQExampleDomain.Entity
{
    public static class Sector
    {
        public static bool ValidSector(string sector)
        {
            var list = new List<string>();

            list.Add("public");
            list.Add("private" );

            return list.Contains(sector.ToLower());
        }
    }
}
