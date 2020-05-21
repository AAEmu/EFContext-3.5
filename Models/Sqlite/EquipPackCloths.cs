using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class EquipPackCloths
    {
        public EquipPackCloths()
        {
            CharacterPreviewCloths = new HashSet<CharacterPreviewCloths>();
            CharacterEquipPacks = new HashSet<CharacterEquipPacks>();
        }

        public long Id { get; set; }
        public long? BackGradeId { get; set; }
        public long? BackId { get; set; }
        public long? BackpackGradeId { get; set; }
        public long? BackpackId { get; set; }
        public long? BeltGradeId { get; set; }
        public long? BeltId { get; set; }
        public long? BraceletGradeId { get; set; }
        public long? BraceletId { get; set; }
        public long? CosplayGradeId { get; set; }
        public long? CosplayId { get; set; }
        public long? GloveGradeId { get; set; }
        public long? GloveId { get; set; }
        public long? HeadgearGradeId { get; set; }
        public long? HeadgearId { get; set; }
        public long? NecklaceGradeId { get; set; }
        public long? NecklaceId { get; set; }
        public long? PantsGradeId { get; set; }
        public long? PantsId { get; set; }
        public long? ShirtGradeId { get; set; }
        public long? ShirtId { get; set; }
        public long? ShoesGradeId { get; set; }
        public long? ShoesId { get; set; }
        public long? StabilizerGradeId { get; set; }
        public long? StabilizerId { get; set; }
        public long? UnderpantsGradeId { get; set; }
        public long? UnderpantsId { get; set; }
        public long? UndershirtGradeId { get; set; }
        public long? UndershirtId { get; set; }

        public virtual ICollection<CharacterPreviewCloths> CharacterPreviewCloths { get; set; }
        public virtual ICollection<CharacterEquipPacks> CharacterEquipPacks { get; set; }
    }
}
