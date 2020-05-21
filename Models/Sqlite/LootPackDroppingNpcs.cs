namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class LootPackDroppingNpcs
    {
        public long? Id { get; set; }
        public long? NpcId { get; set; }
        public long? LootPackId { get; set; }
        public string DefaultPack { get; set; }
    }
}
