namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class CharacterCustomizingHairAssets
    {
        public long? Id { get; set; }
        public long? DisplayOrder { get; set; }
        public long? HairId { get; set; }
        public byte[] IsHot { get; set; }
        public byte[] IsNew { get; set; }
        public long? ModelId { get; set; }
    }
}
