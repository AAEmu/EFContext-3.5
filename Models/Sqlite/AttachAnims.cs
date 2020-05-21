namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class AttachAnims
    {
        public string OwnerType { get; set; }
        public long? OwnerId { get; set; }
        public long? AnimActionId { get; set; }
        public long? AttachPointId { get; set; }

        public virtual AnimActions AnimAction { get; set; }
    }
}
