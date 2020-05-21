namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class LootActabilityGroups
    {
        public long? Id { get; set; }
        public long? LootPackId { get; set; }
        public long? LootGroupId { get; set; }
        public long? MaxDice { get; set; }
        public long? MinDice { get; set; }
    }
}
