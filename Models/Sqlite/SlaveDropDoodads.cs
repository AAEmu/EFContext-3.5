namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SlaveDropDoodads
    {
        public string OwnerType { get; set; }
        public long? OwnerId { get; set; }
        public long? Count { get; set; }
        public long? DoodadId { get; set; }
        public byte[] OnWater { get; set; }
        public double? Radius { get; set; }
        public byte[] SlaveVsSlave { get; set; }
    }
}
