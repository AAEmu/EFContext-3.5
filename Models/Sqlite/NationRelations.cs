namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class NationRelations
    {
        public long Id { get; set; }
        public long? DefaultMemberCount { get; set; }
        public long? HostileEndHour { get; set; }
        public long? HostileEndMinute { get; set; }
        public long? HostileEndWeek { get; set; }
        public long? HostileStartHour { get; set; }
        public long? HostileStartMinute { get; set; }
        public long? HostileStartWeek { get; set; }
        public long? HousingPack1Id { get; set; }
        public long? HousingPack2Id { get; set; }
        public long? HousingPack3Id { get; set; }
        public long? HousingPack4Id { get; set; }
        public long? HousingPack5Id { get; set; }
        public long? ItemCount { get; set; }
        public long? ItemId { get; set; }
        public long? PerMemberCount { get; set; }
        public long? PerMemberItemAdd { get; set; }
        public long? RejectChargePercent { get; set; }
        public long? RequestEndHour { get; set; }
        public long? RequestEndMinute { get; set; }
        public long? RequestEndWeek { get; set; }
        public long? RequestStartHour { get; set; }
        public long? RequestStartMinute { get; set; }
        public long? RequestStartWeek { get; set; }
        public long? VoteEndHour { get; set; }
        public long? VoteEndMinute { get; set; }
        public long? VoteEndWeek { get; set; }
        public long? VoteStartHour { get; set; }
        public long? VoteStartMinute { get; set; }
        public long? VoteStartWeek { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
