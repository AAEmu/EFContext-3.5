namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ExpeditionLevelReqs
    {
        public long Id { get; set; }
        public long? Amount { get; set; }
        public long? ExpeditionLevelId { get; set; }
        public long? ItemId { get; set; }

        public virtual ExpeditionLevels ExpeditionLevel { get; set; }
        public virtual ItemTemplate Item { get; set; }
    }
}
