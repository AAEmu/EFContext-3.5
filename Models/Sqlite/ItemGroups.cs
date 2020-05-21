using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemGroups
    {
        public ItemGroups()
        {
            DefaultInventoryTabGroups = new HashSet<DefaultInventoryTabGroups>();
            ItemCategories = new HashSet<ItemCategories>();
            QuestActObjItemGroupGathers = new HashSet<QuestActObjItemGroupGathers>();
            QuestActObjItemGroupUses = new HashSet<QuestActObjItemGroupUses>();
        }

        public long Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public byte[] VisibleUi { get; set; }

        public virtual ICollection<DefaultInventoryTabGroups> DefaultInventoryTabGroups { get; set; }
        public virtual ICollection<ItemCategories> ItemCategories { get; set; }
        public virtual ICollection<QuestActObjItemGroupGathers> QuestActObjItemGroupGathers { get; set; }
        public virtual ICollection<QuestActObjItemGroupUses> QuestActObjItemGroupUses { get; set; }
    }
}
