using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ZoneClimates
    {
        public ZoneClimates()
        {
            ZoneClimateElems = new HashSet<ZoneClimateElems>();
            Zones = new HashSet<Zones>();
        }

        public long Id { get; set; }

        public virtual ICollection<ZoneClimateElems> ZoneClimateElems { get; set; }
        public virtual ICollection<Zones> Zones { get; set; }
    }
}
