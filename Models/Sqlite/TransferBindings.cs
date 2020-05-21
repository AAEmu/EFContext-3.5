namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class TransferBindings
    {
        public string OwnerType { get; set; }
        public long? OwnerId { get; set; }
        public long? AttachPointId { get; set; }
        public long? TransferId { get; set; }

        public virtual Transfers Transfer { get; set; }
    }
}
