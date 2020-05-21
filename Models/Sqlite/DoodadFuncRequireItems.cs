namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncRequireItems
    {
        public long Id { get; set; }
        public long? ItemId { get; set; }
        public long? WiId { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
