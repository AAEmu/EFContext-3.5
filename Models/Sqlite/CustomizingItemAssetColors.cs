namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class CustomizingItemAssetColors
    {
        public long Id { get; set; }
        public long? AssetId { get; set; }
        public long? CategoryId { get; set; }
        public long? DefaultHairColor { get; set; }
        public long? DisplayOrder { get; set; }
        public long? HairBaseColorR { get; set; }
        public long? HairBaseColorG { get; set; }
        public long? HairBaseColorB { get; set; }
        public string IconPath { get; set; }
        public string Material { get; set; }
        public long? ModelId { get; set; }
        public double? TwoToneFirstWidth { get; set; }
        public long? TwoToneHairColor { get; set; }
        public double? TwoToneSecondWidth { get; set; }

        public virtual Models Model { get; set; }
    }
}
