using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DefaultInventoryTabs
    {
        public DefaultInventoryTabs()
        {
            DefaultInventoryTabGroups = new HashSet<DefaultInventoryTabGroups>();
        }

        public long Id { get; set; }
        public long? IconIdx { get; set; }
        public string Name { get; set; }
        public long? TabOrder { get; set; }

        public virtual ICollection<DefaultInventoryTabGroups> DefaultInventoryTabGroups { get; set; }
    }
}
