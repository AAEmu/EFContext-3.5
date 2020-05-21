namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncAttachments
    {
        public long Id { get; set; }
        public long? AnimActionId { get; set; }
        public long? AttachPointId { get; set; }
        public long? BondKindId { get; set; }
        public long? Space { get; set; }

        public virtual AnimActions AnimAction { get; set; }
    }
}
