namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemAssetTransforms
    {
        public long? ItemId { get; set; }
        public long? ItemAssetId { get; set; }
        public long? StartFxGroupId { get; set; }
        public long? TriggerId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual ItemAssets ItemAsset { get; set; }
    }
}
