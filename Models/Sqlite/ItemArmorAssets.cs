namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemArmorAssets
    {
        public long Id { get; set; }
        public long? ArmorAssetId { get; set; }
        public long? AssetId { get; set; }

        public virtual ArmorAssets ArmorAsset { get; set; }
    }
}
