namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SpawnGimmickEffects
    {
        public long Id { get; set; }
        public long? AngVelCoordiateId { get; set; }
        public double? AngVelX { get; set; }
        public double? AngVelY { get; set; }
        public double? AngVelZ { get; set; }
        public long? GimmickId { get; set; }
        public long? OffsetCoordiateId { get; set; }
        public byte[] OffsetFromSource { get; set; }
        public double? OffsetX { get; set; }
        public double? OffsetY { get; set; }
        public double? OffsetZ { get; set; }
        public double? Scale { get; set; }
        public long? VelocityCoordiateId { get; set; }
        public double? VelocityX { get; set; }
        public double? VelocityY { get; set; }
        public double? VelocityZ { get; set; }

        public virtual Gimmicks Gimmick { get; set; }
    }
}
