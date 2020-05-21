using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Characters
    {
        public Characters()
        {
            CharacterDefaultSkills = new HashSet<CharacterDefaultSkills>();
            CharacterPreviewCloths = new HashSet<CharacterPreviewCloths>();
        }

        public long Id { get; set; }
        public long? CharGenderId { get; set; }
        public long? CharRaceId { get; set; }
        public byte[] Creatable { get; set; }
        public long? DefaultCustomId { get; set; }
        public long? DefaultFxVoiceSoundPackId { get; set; }
        public long? DefaultResurrectionDistrictId { get; set; }
        public long? DefaultReturnDistrictId { get; set; }
        public long? DefaultSystemVoiceSoundPackId { get; set; }
        public long? FaceItemId { get; set; }
        public long? FactionId { get; set; }
        public long? FightPreviewClothPackId { get; set; }
        public long? FightPreviewWeaponPackId { get; set; }
        public long? LovePreviewClothPackId { get; set; }
        public long? LovePreviewWeaponPackId { get; set; }
        public long? MagicPreviewClothPackId { get; set; }
        public long? MagicPreviewWeaponPackId { get; set; }
        public long? ModelId { get; set; }
        public long? PreviewClothPackId { get; set; }
        public long? StartingZoneId { get; set; }
        public long? WildPreviewClothPackId { get; set; }
        public long? WildPreviewWeaponPackId { get; set; }

        public virtual Models Model { get; set; }
        public virtual ICollection<CharacterDefaultSkills> CharacterDefaultSkills { get; set; }
        public virtual ICollection<CharacterPreviewCloths> CharacterPreviewCloths { get; set; }
    }
}
