namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SkillReqSkills
    {
        public long? SkillReqId { get; set; }
        public long? SkillId { get; set; }

        public virtual Skills Skill { get; set; }
        public virtual SkillReqs SkillReq { get; set; }
    }
}
