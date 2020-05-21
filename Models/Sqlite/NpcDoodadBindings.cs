namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class NpcDoodadBindings
    {
        public string OwnerType { get; set; }
        public long? OwnerId { get; set; }
        public long? AttachPointId { get; set; }
        public long? DoodadId { get; set; }
        public byte[] Persist { get; set; }
    }
}
