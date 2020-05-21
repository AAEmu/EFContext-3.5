using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Climates
    {
        public Climates()
        {
            DoodadAlmighties = new HashSet<DoodadAlmighties>();
            ZoneClimateElems = new HashSet<ZoneClimateElems>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DoodadAlmighties> DoodadAlmighties { get; set; }
        public virtual ICollection<ZoneClimateElems> ZoneClimateElems { get; set; }
    }
}
