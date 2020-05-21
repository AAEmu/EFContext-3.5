namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SlaveDoodadBindings
    {
        public string OwnerType { get; set; }
        public long? OwnerId { get; set; }
        public long? AttachPointId { get; set; }
        public byte[] Basic { get; set; }
        public long? DoodadId { get; set; }
        public byte[] Persist { get; set; }
        public double? Scale { get; set; }
    }
}
