namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class FarmGroupDoodads
    {
        public long Id { get; set; }
        public long? DoodadId { get; set; }
        public long? FarmGroupId { get; set; }
        public long? ItemId { get; set; }

        public virtual FarmGroups FarmGroup { get; set; }
        public virtual ItemTemplate Item { get; set; }
    }
}
