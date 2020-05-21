namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class AccountAttributeEffects
    {
        public long Id { get; set; }
        public byte[] BindWorld { get; set; }
        public long? Count { get; set; }
        public byte[] IsAdd { get; set; }
        public long? KindId { get; set; }
        public long? KindValue { get; set; }
        public long? Time { get; set; }
    }
}
