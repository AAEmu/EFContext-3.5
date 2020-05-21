using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class EquipSlotGroups
    {
        public EquipSlotGroups()
        {
            EquipSlotGroupMaps = new HashSet<EquipSlotGroupMaps>();
            ItemEnchantingGems = new HashSet<ItemEnchantingGems>();
            ItemSockets = new HashSet<ItemSockets>();
        }

        public long Id { get; set; }
        public byte[] PetOnly { get; set; }

        public virtual ICollection<EquipSlotGroupMaps> EquipSlotGroupMaps { get; set; }
        public virtual ICollection<ItemEnchantingGems> ItemEnchantingGems { get; set; }
        public virtual ICollection<ItemSockets> ItemSockets { get; set; }
    }
}
