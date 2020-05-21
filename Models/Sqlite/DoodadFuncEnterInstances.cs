namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncEnterInstances
    {
        public long Id { get; set; }
        public long? ItemId { get; set; }
        public long? ZoneId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual Zones Zone { get; set; }
    }
}
