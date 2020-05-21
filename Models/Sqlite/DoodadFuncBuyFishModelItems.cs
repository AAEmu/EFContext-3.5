namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncBuyFishModelItems
    {
        public long Id { get; set; }
        public long? DoodadFuncBuyFishModelId { get; set; }
        public long? ItemId { get; set; }
        public string Model { get; set; }

        public virtual DoodadFuncBuyFishModels DoodadFuncBuyFishModel { get; set; }
        public virtual ItemTemplate Item { get; set; }
    }
}
