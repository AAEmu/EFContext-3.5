namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemShipyards
    {
        public long? ItemId { get; set; }
        public long? ShipyardId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual Shipyards Shipyard { get; set; }
    }
}
