using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemGuides
    {
        public ItemGuides()
        {
            ItemGuideIcons = new HashSet<ItemGuideIcons>();
            Items = new HashSet<ItemTemplate>();
        }

        public long Id { get; set; }
        public long? ItemGuideCategoryId { get; set; }
        public long? Level { get; set; }
        public long? LootMainCategoryId { get; set; }
        public long? LootSubCategoryId { get; set; }
        public string Name { get; set; }
        public byte[] Show { get; set; }
        public long? ShowOrder { get; set; }
        public string WayToLoot { get; set; }
        public long? ZoneKey { get; set; }

        public virtual ICollection<ItemGuideIcons> ItemGuideIcons { get; set; }
        public virtual ICollection<ItemTemplate> Items { get; set; }
    }
}
