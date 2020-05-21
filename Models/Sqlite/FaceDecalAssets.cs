namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class FaceDecalAssets
    {
        public long Id { get; set; }
        public string AssetPath { get; set; }
        public long? CategoryId { get; set; }
        public long? DefaultX { get; set; }
        public long? DefaultY { get; set; }
        public long? DisplayOrder { get; set; }
        public string IconPath { get; set; }
        public byte[] IsNew { get; set; }
        public long? ItemId { get; set; }
        public long? ModelId { get; set; }
        public byte[] Movable { get; set; }
        public string Name { get; set; }
        public byte[] NpcOnly { get; set; }
        public string OddEyeInfo { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual Models Model { get; set; }
    }
}
