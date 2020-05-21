namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActCheckTimers
    {
        public long Id { get; set; }
        public long? BuffId { get; set; }
        public byte[] CheckBuf { get; set; }
        public byte[] ForceChangeComponent { get; set; }
        public byte[] IsSkillPlayer { get; set; }
        public long? LimitTime { get; set; }
        public long? NextComponent { get; set; }
        public byte[] PlaySkill { get; set; }
        public long? SkillId { get; set; }
        public byte[] SustainBuf { get; set; }
        public long? TimerNpcId { get; set; }

        public virtual Buffs Buff { get; set; }
        public virtual Skills Skill { get; set; }
    }
}
