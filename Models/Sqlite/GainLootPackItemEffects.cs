namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class GainLootPackItemEffects
    {
        public long Id { get; set; }
        public long? ConsumeCount { get; set; }
        public long? ConsumeItemId { get; set; }
        public byte[] ConsumeSourceItem { get; set; }
        public byte[] InheritGrade { get; set; }
        public long? LootPackId { get; set; }
    }
}
