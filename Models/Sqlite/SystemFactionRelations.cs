namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SystemFactionRelations
    {
        public long Id { get; set; }
        public long? Faction1Id { get; set; }
        public long? Faction2Id { get; set; }
        public long? StateId { get; set; }
    }
}
