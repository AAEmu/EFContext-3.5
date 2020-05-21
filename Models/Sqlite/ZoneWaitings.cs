using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ZoneWaitings
    {
        public ZoneWaitings()
        {
            ZoneWaitingFactions = new HashSet<ZoneWaitingFactions>();
        }

        public long Id { get; set; }
        public string DisplayText { get; set; }
        public string Name { get; set; }
        public long? ZoneGroupId { get; set; }

        public virtual ZoneGroups ZoneGroup { get; set; }
        public virtual ICollection<ZoneWaitingFactions> ZoneWaitingFactions { get; set; }
    }
}
