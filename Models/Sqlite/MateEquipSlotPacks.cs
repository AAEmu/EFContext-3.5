using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class MateEquipSlotPacks
    {
        public MateEquipSlotPacks()
        {
            Npcs = new HashSet<Npcs>();
        }

        public long Id { get; set; }
        public byte[] Chest { get; set; }
        public byte[] Feet { get; set; }
        public byte[] Head { get; set; }
        public long? MateTypeId { get; set; }
        public string Name { get; set; }
        public byte[] Waist { get; set; }

        public virtual ICollection<Npcs> Npcs { get; set; }
    }
}
