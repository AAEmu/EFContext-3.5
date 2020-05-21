namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class RankingRewards
    {
        public long Id { get; set; }
        public long? Begin { get; set; }
        public string Code { get; set; }
        public string Division { get; set; }
        public long? End { get; set; }
        public long? ItemCount { get; set; }
        public long? ItemId { get; set; }
        public string Name { get; set; }
        public string Ranking { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
