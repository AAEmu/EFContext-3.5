namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class MineJewelRates
    {
        public string Id { get; set; }
        public string JewelItemId { get; set; }
        public string MineItemId { get; set; }
        public string Rate { get; set; }
    }
}
