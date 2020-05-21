namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class TowerDefProgSpawnTargets
    {
        public long Id { get; set; }
        public byte[] DespawnOnNextStep { get; set; }
        public string SpawnTargetType { get; set; }
        public long? SpawnTargetId { get; set; }
        public long? TowerDefProgId { get; set; }

        public virtual TowerDefProgs TowerDefProg { get; set; }
    }
}
