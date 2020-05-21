namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SlaveInitialItems
    {
        public long Id { get; set; }
        public long? EquipSlotId { get; set; }
        public long? ItemId { get; set; }
        public long? SlaveInitialItemPackId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual SlaveInitialItemPacks SlaveInitialItemPack { get; set; }
    }
}
