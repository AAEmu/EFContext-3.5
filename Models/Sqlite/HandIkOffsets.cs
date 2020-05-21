namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HandIkOffsets
    {
        public string OwnerType { get; set; }
        public long? OwnerId { get; set; }
        public double? IkOffsetX { get; set; }
        public double? IkOffsetY { get; set; }
        public double? IkOffsetZ { get; set; }
        public long? ModelId { get; set; }

        public virtual Models Model { get; set; }
    }
}
