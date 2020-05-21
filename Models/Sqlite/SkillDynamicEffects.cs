namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SkillDynamicEffects
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Effect { get; set; }
        public long? SkillId { get; set; }

        public virtual Skills Skill { get; set; }
    }
}
