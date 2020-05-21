using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HeirSkills
    {
        public HeirSkills()
        {
            HeirSkillDetails = new HashSet<HeirSkillDetails>();
        }

        public long Id { get; set; }
        public long? SkillId { get; set; }
        public long? Step { get; set; }

        public virtual Skills Skill { get; set; }
        public virtual ICollection<HeirSkillDetails> HeirSkillDetails { get; set; }
    }
}
