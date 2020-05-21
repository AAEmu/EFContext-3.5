namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SpawnEffects
    {
        public long Id { get; set; }
        public byte[] DespawnOnCreatorDeath { get; set; }
        public double? LifeTime { get; set; }
        public long? MateStateId { get; set; }
        public double? OriAngle { get; set; }
        public long? OriDirId { get; set; }
        public long? OwnerTypeId { get; set; }
        public double? PosAngleMax { get; set; }
        public double? PosAngleMin { get; set; }
        public long? PosDirId { get; set; }
        public double? PosDistanceMax { get; set; }
        public double? PosDistanceMin { get; set; }
        public long? SubType { get; set; }
        public byte[] UseSummonerAggroTarget { get; set; }
        public byte[] UseSummonerFaction { get; set; }
    }
}
