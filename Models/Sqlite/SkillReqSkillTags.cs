namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SkillReqSkillTags
    {
        public long? SkillReqId { get; set; }
        public long? SkillTagId { get; set; }

        public virtual SkillReqs SkillReq { get; set; }
    }
}
