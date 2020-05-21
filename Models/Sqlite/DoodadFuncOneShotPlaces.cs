namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncOneShotPlaces
    {
        public long Id { get; set; }
        public long? ItemSetId { get; set; }

        public virtual ItemSets ItemSet { get; set; }
    }
}
