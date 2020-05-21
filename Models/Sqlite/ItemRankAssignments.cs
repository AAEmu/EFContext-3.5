namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemRankAssignments
    {
        public long Id { get; set; }
        public long? HoldableId { get; set; }
        public long? RankingId { get; set; }

        public virtual Holdables Holdable { get; set; }
        public virtual Rankings Ranking { get; set; }
    }
}
