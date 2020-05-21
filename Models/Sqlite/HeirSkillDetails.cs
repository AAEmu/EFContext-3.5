namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HeirSkillDetails
    {
        public long Id { get; set; }
        public long? HeirSkillId { get; set; }
        public long? Point { get; set; }
        public long? Pos { get; set; }
        public long? SkillId { get; set; }

        public virtual HeirSkills HeirSkill { get; set; }
        public virtual Skills Skill { get; set; }
    }
}
