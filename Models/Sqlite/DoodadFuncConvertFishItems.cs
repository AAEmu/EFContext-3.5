namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncConvertFishItems
    {
        public long Id { get; set; }
        public long? DoodadFuncConvertFishId { get; set; }
        public long? ItemId { get; set; }
        public long? LootPackId { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
