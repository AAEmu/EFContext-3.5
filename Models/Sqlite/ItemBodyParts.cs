namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemBodyParts
    {
        public long? ItemId { get; set; }
        public long? Asset1Id { get; set; }
        public long? Asset2Id { get; set; }
        public long? Asset3Id { get; set; }
        public long? Asset4Id { get; set; }
        public long? AssetId { get; set; }
        public long? CustomTextureId { get; set; }
        public long? CustomTexture1Id { get; set; }
        public long? CustomTexture2Id { get; set; }
        public long? CustomTexture3Id { get; set; }
        public long? CustomTexture4Id { get; set; }
        public string FaceMask { get; set; }
        public string HairBase { get; set; }
        public long? LeftEyeHeight { get; set; }
        public long? LeftEyeWidth { get; set; }
        public long? LeftEyeX { get; set; }
        public long? LeftEyeY { get; set; }
        public long? ModelId { get; set; }
        public byte[] NpcOnly { get; set; }
        public byte[] OddEye { get; set; }
        public long? RightEyeHeight { get; set; }
        public long? RightEyeWidth { get; set; }
        public long? RightEyeX { get; set; }
        public long? RightEyeY { get; set; }
        public long? SlotTypeId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual Models Model { get; set; }
    }
}
