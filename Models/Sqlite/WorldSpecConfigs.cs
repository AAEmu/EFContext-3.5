namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class WorldSpecConfigs
    {
        public string WorldId { get; set; }
        public string SpecialtyMax { get; set; }
        public string SpecialtyMin { get; set; }
        public string SpecialtyAdjustUp { get; set; }
        public string SpecialtyAdjustDown { get; set; }
        public string TradegoodsMax { get; set; }
        public string TradegoodsMin { get; set; }
        public string TradegoodsAdjustUp { get; set; }
        public string TradegoodsAdjustDown { get; set; }
    }
}
