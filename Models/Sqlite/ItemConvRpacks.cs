using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemConvRpacks
    {
        public ItemConvRpacks()
        {
            ItemConvReagentFilters = new HashSet<ItemConvReagentFilters>();
            ItemConvReagents = new HashSet<ItemConvReagents>();
            ItemConvRpackMembers = new HashSet<ItemConvRpackMembers>();
        }

        public long Id { get; set; }

        public virtual ICollection<ItemConvReagentFilters> ItemConvReagentFilters { get; set; }
        public virtual ICollection<ItemConvReagents> ItemConvReagents { get; set; }
        public virtual ICollection<ItemConvRpackMembers> ItemConvRpackMembers { get; set; }
    }
}
