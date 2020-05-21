namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HeavyTaxes
    {
        public long Id { get; set; }
        public long? Count { get; set; }
        public double? Multiplier { get; set; }
    }
}
