namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ShipyardRewards
    {
        public long Id { get; set; }
        public long? Count { get; set; }
        public long? DoodadId { get; set; }
        public byte[] OnWater { get; set; }
        public double? Radius { get; set; }
        public long? ShipyardId { get; set; }

        public virtual Shipyards Shipyard { get; set; }
    }
}
