namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncRatioRespawns
    {
        public long Id { get; set; }
        public long? Ratio { get; set; }
        public long? SpawnDoodadId { get; set; }
    }
}
