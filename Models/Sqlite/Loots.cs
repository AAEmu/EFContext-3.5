namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Loots
    {
        public long? Id { get; set; }
        public long? Group { get; set; }
        public long? ItemId { get; set; }
        public long? DropRate { get; set; }
        public long? MinAmount { get; set; }
        public long? MaxAmount { get; set; }
        public long? LootPackId { get; set; }
        public long? GradeId { get; set; }
        public string AlwaysDrop { get; set; }
    }
}
