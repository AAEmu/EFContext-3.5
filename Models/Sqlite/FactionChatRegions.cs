using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class FactionChatRegions
    {
        public FactionChatRegions()
        {
            ZoneGroups = new HashSet<ZoneGroups>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ZoneGroups> ZoneGroups { get; set; }
    }
}
