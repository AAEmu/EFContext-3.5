namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncLootItems
    {
        public long Id { get; set; }
        public long? CountMax { get; set; }
        public long? CountMin { get; set; }
        public long? GroupId { get; set; }
        public long? ItemId { get; set; }
        public long? Percent { get; set; }
        public long? RemainTime { get; set; }
        public long? WiId { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
