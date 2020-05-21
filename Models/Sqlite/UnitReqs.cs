namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class UnitReqs
    {
        public string OwnerType { get; set; }
        public long? OwnerId { get; set; }
        public byte[] DisplayMsg { get; set; }
        public long? KindId { get; set; }
        public long? Value1 { get; set; }
        public long? Value2 { get; set; }
        public long? Value3 { get; set; }
    }
}
