namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BattleFieldBannedTags
    {
        public long Id { get; set; }
        public long? BattleFieldId { get; set; }
        public long? TagId { get; set; }

        public virtual BattleFields BattleField { get; set; }
        public virtual Tags Tag { get; set; }
    }
}
