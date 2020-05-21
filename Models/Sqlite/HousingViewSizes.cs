using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HousingViewSizes
    {
        public HousingViewSizes()
        {
            HousingSizes = new HashSet<HousingSizes>();
        }

        public long Id { get; set; }
        public long? Value { get; set; }

        public virtual ICollection<HousingSizes> HousingSizes { get; set; }
    }
}
