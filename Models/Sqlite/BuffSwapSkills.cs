namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BuffSwapSkills
    {
        public long Id { get; set; }
        public long? BuffId { get; set; }
        public long? NewSkillId { get; set; }
        public long? OriginSkillId { get; set; }
        public long? Priority { get; set; }

        public virtual Buffs Buff { get; set; }
    }
}
