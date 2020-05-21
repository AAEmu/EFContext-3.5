namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemBackpacks
    {
        public long? ItemId { get; set; }
        public long? Asset2Id { get; set; }
        public long? AssetId { get; set; }
        public long? BackpackTypeId { get; set; }
        public long? DeclareSiegeZoneGroupId { get; set; }
        public long? FreshnessGroupId { get; set; }
        public long? GliderAnimActionId { get; set; }
        public long? GliderFastAnimActionId { get; set; }
        public long? GliderSlidingAnimActionId { get; set; }
        public long? GliderSlowAnimActionId { get; set; }
        public byte[] Heavy { get; set; }
        public byte[] NormalSpecialty { get; set; }
        public long? SkinKindId { get; set; }
        public string StorageVisual { get; set; }
        public byte[] UseAsStat { get; set; }

        public virtual FreshnessGroups FreshnessGroup { get; set; }
        public virtual ItemTemplate Item { get; set; }
    }
}
