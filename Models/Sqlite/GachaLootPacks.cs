using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class GachaLootPacks
    {
        public GachaLootPacks()
        {
            GachaLootPackItems = new HashSet<GachaLootPackItems>();
        }

        public long Id { get; set; }
        public long? LootPackId { get; set; }
        public byte[] Active { get; set; }

        public virtual ICollection<GachaLootPackItems> GachaLootPackItems { get; set; }
    }
}
