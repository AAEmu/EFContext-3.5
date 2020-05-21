using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemConvPpacks
    {
        public ItemConvPpacks()
        {
            ItemConvPpackMembers = new HashSet<ItemConvPpackMembers>();
            ItemConvProducts = new HashSet<ItemConvProducts>();
        }

        public long Id { get; set; }
        public long? ChanceRate { get; set; }

        public virtual ICollection<ItemConvPpackMembers> ItemConvPpackMembers { get; set; }
        public virtual ICollection<ItemConvProducts> ItemConvProducts { get; set; }
    }
}
