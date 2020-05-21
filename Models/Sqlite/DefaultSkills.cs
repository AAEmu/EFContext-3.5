using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DefaultSkills
    {
        public DefaultSkills()
        {
            CharacterDefaultSkills = new HashSet<CharacterDefaultSkills>();
        }

        public long Id { get; set; }
        public byte[] AddToSlot { get; set; }
        public long? SkillActiveTypeId { get; set; }
        public long? SkillBookCategoryId { get; set; }
        public long? SkillId { get; set; }
        public long? SlotIndex { get; set; }

        public virtual Skills Skill { get; set; }
        public virtual ICollection<CharacterDefaultSkills> CharacterDefaultSkills { get; set; }
    }
}
