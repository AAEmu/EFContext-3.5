namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncBuyFishItems
    {
        public long Id { get; set; }
        public long? DoodadFuncBuyFishId { get; set; }
        public long? ItemId { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
