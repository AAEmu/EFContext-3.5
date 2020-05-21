using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class EquipPackWeapons
    {
        public EquipPackWeapons()
        {
            CharacterEquipPacks = new HashSet<CharacterEquipPacks>();
        }

        public long Id { get; set; }
        public long? MainhandGradeId { get; set; }
        public long? MainhandId { get; set; }
        public long? MusicalGradeId { get; set; }
        public long? MusicalId { get; set; }
        public long? OffhandGradeId { get; set; }
        public long? OffhandId { get; set; }
        public long? RangedGradeId { get; set; }
        public long? RangedId { get; set; }
        
        public virtual ICollection<CharacterEquipPacks> CharacterEquipPacks { get; set; }
    }
}
