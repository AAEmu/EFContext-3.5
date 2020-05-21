namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HousingRebuildingPackRebuildings
    {
        public long Id { get; set; }
        public long? HousingRebuildingId { get; set; }
        public long? HousingRebuildingPackId { get; set; }
        public long? Position { get; set; }

        public virtual HousingRebuildings HousingRebuilding { get; set; }
        public virtual HousingRebuildingPacks HousingRebuildingPack { get; set; }
    }
}
