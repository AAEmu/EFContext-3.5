using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SlaveCustomizings
    {
        public SlaveCustomizings()
        {
            SlaveCustomizingEquipSlots = new HashSet<SlaveCustomizingEquipSlots>();
            Slaves = new HashSet<Slaves>();
        }

        public long Id { get; set; }

        public virtual ICollection<SlaveCustomizingEquipSlots> SlaveCustomizingEquipSlots { get; set; }
        public virtual ICollection<Slaves> Slaves { get; set; }
    }
}
