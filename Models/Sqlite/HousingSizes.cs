using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HousingSizes
    {
        public HousingSizes()
        {
            Housings = new HashSet<Housings>();
        }

        public long Id { get; set; }
        public double? GardenRadius { get; set; }
        public long? HousingViewSizeId { get; set; }

        public virtual HousingViewSizes HousingViewSize { get; set; }
        public virtual ICollection<Housings> Housings { get; set; }
    }
}
