namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemCapScaleRandomRates
    {
        public long Id { get; set; }
        public long? CapScaleId { get; set; }
        public long? CapScaleValue { get; set; }
        public long? ScaleRandomRate { get; set; }
    }
}
