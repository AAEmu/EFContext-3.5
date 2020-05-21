using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HousingRebuildingPacks
    {
        public HousingRebuildingPacks()
        {
            HousingRebuildingPackRebuildings = new HashSet<HousingRebuildingPackRebuildings>();
            Housings = new HashSet<Housings>();
        }

        public long Id { get; set; }

        public virtual ICollection<HousingRebuildingPackRebuildings> HousingRebuildingPackRebuildings { get; set; }
        public virtual ICollection<Housings> Housings { get; set; }
    }
}
