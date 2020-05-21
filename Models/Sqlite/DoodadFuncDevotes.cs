namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncDevotes
    {
        public long Id { get; set; }
        public long? Count { get; set; }
        public long? ItemCount { get; set; }
        public long? ItemId { get; set; }
        public string TooltipText { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
