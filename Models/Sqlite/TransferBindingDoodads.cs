namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class TransferBindingDoodads
    {
        public string OwnerType { get; set; }
        public long? OwnerId { get; set; }
        public long? AttachPointId { get; set; }
        public long? DoodadId { get; set; }
    }
}
