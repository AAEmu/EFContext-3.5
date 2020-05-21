namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ModelBindings
    {
        public string OwnerType { get; set; }
        public long? OwnerId { get; set; }
        public long? AttachPointId { get; set; }
        public double? BreathZ { get; set; }
        public byte[] HorseRein { get; set; }
        public byte[] NotCollideWithCamera { get; set; }
        public double? OffsetX { get; set; }
        public double? OffsetY { get; set; }
        public double? OffsetZ { get; set; }
    }
}
