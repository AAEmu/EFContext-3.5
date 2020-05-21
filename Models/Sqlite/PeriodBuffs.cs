namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class PeriodBuffs
    {
        public long Id { get; set; }
        public long? AddMaxLp { get; set; }
        public long? AddSpecialityRatio { get; set; }
        public long? BuffId { get; set; }
        public long? OfflineLaborpower { get; set; }
        public long? OnlineLaborpower { get; set; }
        public byte[] ReplacePremiumOfflineLp { get; set; }
        public byte[] ReplacePremiumOnlineLp { get; set; }
        public byte[] UseAuctionConfig { get; set; }

        public virtual Buffs Buff { get; set; }
    }
}
