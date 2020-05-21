using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemEnchantRatioGroups
    {
        public ItemEnchantRatioGroups()
        {
            ItemEnchantRatioItems = new HashSet<ItemEnchantRatioItems>();
            ItemEnchantRatios = new HashSet<ItemEnchantRatios>();
        }

        public long Id { get; set; }
        public long? ItemImplId { get; set; }
        public long? ItemEnchantRatioKindId { get; set; }

        public virtual ICollection<ItemEnchantRatioItems> ItemEnchantRatioItems { get; set; }
        public virtual ICollection<ItemEnchantRatios> ItemEnchantRatios { get; set; }
    }
}
