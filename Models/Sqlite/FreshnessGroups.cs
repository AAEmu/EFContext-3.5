using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class FreshnessGroups
    {
        public FreshnessGroups()
        {
            FreshnessGroupItems = new HashSet<FreshnessGroupItems>();
            ItemBackpacks = new HashSet<ItemBackpacks>();
        }

        public long Id { get; set; }

        public virtual ICollection<FreshnessGroupItems> FreshnessGroupItems { get; set; }
        public virtual ICollection<ItemBackpacks> ItemBackpacks { get; set; }
    }
}
