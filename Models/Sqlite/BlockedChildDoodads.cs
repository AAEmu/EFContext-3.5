namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BlockedChildDoodads
    {
        public string OwnerType { get; set; }
        public long? OwnerId { get; set; }
        public long? DoodadId { get; set; }
    }
}
