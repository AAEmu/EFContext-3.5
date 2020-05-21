namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ZoneGroupBannedTags
    {
        public long Id { get; set; }
        public long? BannedPeriodsId { get; set; }
        public long? TagId { get; set; }
        public string Usage { get; set; }
        public long? ZoneGroupId { get; set; }

        public virtual Tags Tag { get; set; }
        public virtual ZoneGroups ZoneGroup { get; set; }
    }
}
