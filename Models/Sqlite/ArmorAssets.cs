using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ArmorAssets
    {
        public ArmorAssets()
        {
            ItemArmorAssets = new HashSet<ItemArmorAssets>();
        }

        public long Id { get; set; }
        public long? DefaultAssetId { get; set; }
        public long? SlotTypeId { get; set; }

        public virtual ICollection<ItemArmorAssets> ItemArmorAssets { get; set; }
    }
}
