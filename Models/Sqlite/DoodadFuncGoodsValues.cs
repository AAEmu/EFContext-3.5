namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncGoodsValues
    {
        public long Id { get; set; }
        public long? JackpotMax { get; set; }
        public long? JackpotMin { get; set; }
        public long? JackpotRatio { get; set; }
        public long? NormalMax { get; set; }
        public long? NormalMin { get; set; }
        public long? WeightScope { get; set; }
    }
}
