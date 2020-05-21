using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemRndAttrUnitModifierGroupSets
    {
        public ItemRndAttrUnitModifierGroupSets()
        {
            ItemRndAttrUnitModifierGroups = new HashSet<ItemRndAttrUnitModifierGroups>();
        }

        public long Id { get; set; }
        public long? ItemRndAttrCategoryId { get; set; }
        public string Name { get; set; }
        public long? PickNum { get; set; }
        public long? Weight { get; set; }

        public virtual ICollection<ItemRndAttrUnitModifierGroups> ItemRndAttrUnitModifierGroups { get; set; }
    }
}
