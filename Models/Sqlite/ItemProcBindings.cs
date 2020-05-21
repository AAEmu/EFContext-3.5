namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemProcBindings
    {
        public long Id { get; set; }
        public long? ItemId { get; set; }
        public long? ProcId { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
