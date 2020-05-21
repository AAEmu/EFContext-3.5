using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class EquipItemSets
    {
        public EquipItemSets()
        {
            EquipItemSetBonuses = new HashSet<EquipItemSetBonuses>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public byte[] Wear { get; set; }

        public virtual ICollection<EquipItemSetBonuses> EquipItemSetBonuses { get; set; }
    }
}
