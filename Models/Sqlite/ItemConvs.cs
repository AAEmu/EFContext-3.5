using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemConvs
    {
        public ItemConvs()
        {
            ItemConvPpackMembers = new HashSet<ItemConvPpackMembers>();
            ItemConvRpackMembers = new HashSet<ItemConvRpackMembers>();
        }

        public long Id { get; set; }
        public long? ItemConvSetId { get; set; }

        public virtual ItemConvSets ItemConvSet { get; set; }
        public virtual ICollection<ItemConvPpackMembers> ItemConvPpackMembers { get; set; }
        public virtual ICollection<ItemConvRpackMembers> ItemConvRpackMembers { get; set; }
    }
}
