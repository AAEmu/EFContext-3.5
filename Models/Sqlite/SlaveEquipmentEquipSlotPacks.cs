using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SlaveEquipmentEquipSlotPacks
    {
        public SlaveEquipmentEquipSlotPacks()
        {
            AllowToEquipSlots = new HashSet<AllowToEquipSlots>();
        }

        public long Id { get; set; }
        public long? GradeEnchantCost { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AllowToEquipSlots> AllowToEquipSlots { get; set; }
    }
}
