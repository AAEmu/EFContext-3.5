namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncRemoveInstances
    {
        public long Id { get; set; }
        public long? ZoneId { get; set; }

        public virtual Zones Zone { get; set; }
    }
}
