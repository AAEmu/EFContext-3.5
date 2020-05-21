namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncConsumeChangers
    {
        public long Id { get; set; }
        public long? Count { get; set; }
        public long? SlotId { get; set; }
        public long? TagId { get; set; }

        public virtual Tags Tag { get; set; }
    }
}
