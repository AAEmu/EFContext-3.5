namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HousingRebuildingMaterials
    {
        public long Id { get; set; }
        public long? Count { get; set; }
        public long? HousingRebuildingId { get; set; }
        public long? ItemId { get; set; }

        public virtual HousingRebuildings HousingRebuilding { get; set; }
        public virtual ItemTemplate Item { get; set; }
    }
}
