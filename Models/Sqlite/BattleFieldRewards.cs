namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BattleFieldRewards
    {
        public long Id { get; set; }
        public long? BattleFieldId { get; set; }
        public long? ItemId { get; set; }
        public long? KindId { get; set; }
        public long? RankEnd { get; set; }
        public long? RankStart { get; set; }

        public virtual BattleFields BattleField { get; set; }
        public virtual ItemTemplate Item { get; set; }
    }
}
