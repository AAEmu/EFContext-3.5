namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class PcbangBuffs
    {
        public long Id { get; set; }
        public byte[] Active { get; set; }
        public long? BuffId { get; set; }
        public long? KindId { get; set; }
        public long? PremiumGradeId { get; set; }

        public virtual Buffs Buff { get; set; }
        public virtual PremiumGrades PremiumGrade { get; set; }
    }
}
