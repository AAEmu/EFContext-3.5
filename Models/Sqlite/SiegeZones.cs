namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SiegeZones
    {
        public long? ZoneGroupId { get; set; }
        public long? DeclareItemId { get; set; }
        public long? DefenseMerchantId { get; set; }
        public long? DefenseTicketId { get; set; }
        public long? DominionMerchantId { get; set; }
        public long? MonumentDoodadId { get; set; }
        public long? OffenseMerchantId { get; set; }
        public long? OffenseTicketId { get; set; }
        public long? OpenDurationHours { get; set; }
        public long? OpenHour { get; set; }
        public long? OpenWeekday { get; set; }
        public long? PayHour { get; set; }
        public long? PayItem1Num { get; set; }
        public long? PayItem1Id { get; set; }
        public long? PayItem2Num { get; set; }
        public long? PayItem2Id { get; set; }
        public long? PayItem3Num { get; set; }
        public long? PayItem3Id { get; set; }
        public long? PayItem4Num { get; set; }
        public long? PayItem4Id { get; set; }
        public long? PayItem5Num { get; set; }
        public long? PayItem5Id { get; set; }
        public long? PayMin { get; set; }
        public long? PayWeekday { get; set; }
        public long? ReinforceDefenseDelayMins { get; set; }
        public long? SiegeDays { get; set; }
        public long? SiegeHours { get; set; }
        public long? SiegeMins { get; set; }
        public long? StartAuctionHour { get; set; }
        public long? StartAuctionMin { get; set; }
        public long? StartAuctionWeekday { get; set; }
        public long? StartDeclareHour { get; set; }
        public long? StartDeclareMin { get; set; }
        public long? StartDeclareWeekday { get; set; }
        public long? StartSiegeHour { get; set; }
        public long? StartSiegeMin { get; set; }
        public long? StartSiegeWeekday { get; set; }
        public long? StartWarmupHour { get; set; }
        public long? StartWarmupMin { get; set; }
        public long? StartWarmupWeekday { get; set; }

        public virtual ZoneGroups ZoneGroup { get; set; }
    }
}
