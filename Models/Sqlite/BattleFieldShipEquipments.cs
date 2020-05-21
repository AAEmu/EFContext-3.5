namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BattleFieldShipEquipments
    {
        public long Id { get; set; }
        public byte[] Enable { get; set; }
        public long? ItemId { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
