namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class AchievementObjectives
    {
        public long Id { get; set; }
        public long? AchievementId { get; set; }
        public byte[] OrUnitReqs { get; set; }
        public long? RecordId { get; set; }

        public virtual Achievements Achievement { get; set; }
    }
}
