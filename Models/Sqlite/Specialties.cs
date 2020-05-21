namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Specialties
    {
        public long Id { get; set; }
        public long? ColZoneGroupId { get; set; }
        public long? Profit { get; set; }
        public long? Ratio { get; set; }
        public long? RowZoneGroupId { get; set; }
        public byte[] VendorExist { get; set; }
    }
}
