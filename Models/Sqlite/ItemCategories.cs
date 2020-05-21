namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemCategories
    {
        public long Id { get; set; }
        public long? AuctionCharge { get; set; }
        public byte[] AuctionChargeDefault { get; set; }
        public byte[] AuctionChargeEachItem { get; set; }
        public long? CategoryOrder { get; set; }
        public long? Impl1Id { get; set; }
        public long? ItemGroupId { get; set; }
        public string Name { get; set; }
        public long? ProcessedStateId { get; set; }
        public byte[] Secure { get; set; }
        public long? UsageId { get; set; }
        public long? UseOrEquipmentSoundId { get; set; }

        public virtual ItemGroups ItemGroup { get; set; }
    }
}
