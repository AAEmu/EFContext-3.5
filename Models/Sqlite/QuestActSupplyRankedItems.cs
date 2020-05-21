namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActSupplyRankedItems
    {
        public long Id { get; set; }
        public long? Count { get; set; }
        public long? GradeId { get; set; }
        public long? ItemId { get; set; }
        public long? Rank { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
