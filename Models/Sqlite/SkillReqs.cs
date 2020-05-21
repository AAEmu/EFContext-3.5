using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SkillReqs
    {
        public SkillReqs()
        {
            SkillReqSkillTags = new HashSet<SkillReqSkillTags>();
            SkillReqSkills = new HashSet<SkillReqSkills>();
        }

        public long Id { get; set; }
        public long? BuffTagId { get; set; }
        public long? BuffId { get; set; }
        public byte[] DefaultResult { get; set; }
        public string Message { get; set; }
        public byte[] Target { get; set; }

        public virtual Buffs Buff { get; set; }
        public virtual ICollection<SkillReqSkillTags> SkillReqSkillTags { get; set; }
        public virtual ICollection<SkillReqSkills> SkillReqSkills { get; set; }
    }
}
