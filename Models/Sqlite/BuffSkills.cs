namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BuffSkills
    {
        public long? BuffId { get; set; }
        public long? SkillId { get; set; }

        public virtual Buffs Buff { get; set; }
        public virtual Skills Skill { get; set; }
    }
}
