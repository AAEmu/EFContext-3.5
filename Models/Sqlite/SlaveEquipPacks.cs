using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SlaveEquipPacks
    {
        public SlaveEquipPacks()
        {
            AllowToEquipSlaves = new HashSet<AllowToEquipSlaves>();
            ItemSlaveEquipmentSlaveEquipslotPacks = new HashSet<ItemSlaveEquipmentSlaveEquipslotPacks>();
            ItemSlaveEquipments = new HashSet<ItemSlaveEquipments>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AllowToEquipSlaves> AllowToEquipSlaves { get; set; }
        public virtual ICollection<ItemSlaveEquipmentSlaveEquipslotPacks> ItemSlaveEquipmentSlaveEquipslotPacks { get; set; }
        public virtual ICollection<ItemSlaveEquipments> ItemSlaveEquipments { get; set; }
    }
}
