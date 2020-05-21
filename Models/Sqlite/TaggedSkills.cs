namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class TaggedSkills
    {
        public long Id { get; set; }
        public long? SkillId { get; set; }
        public long? TagId { get; set; }

        public virtual Skills Skill { get; set; }
        public virtual Tags Tag { get; set; }
    }
}
