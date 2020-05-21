namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SphereSkills
    {
        public long Id { get; set; }
        public long? MaxRate { get; set; }
        public long? MinRate { get; set; }
        public long? SkillId { get; set; }

        public virtual Skills Skill { get; set; }
    }
}
