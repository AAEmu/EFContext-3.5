namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SpawnFishEffects
    {
        public long Id { get; set; }
        public long? DoodadId { get; set; }
        public long? Range { get; set; }
    }
}
