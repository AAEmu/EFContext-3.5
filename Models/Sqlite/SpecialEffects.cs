namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SpecialEffects
    {
        public long Id { get; set; }
        public long? SpecialEffectTypeId { get; set; }
        public long? Value1 { get; set; }
        public long? Value2 { get; set; }
        public long? Value3 { get; set; }
        public long? Value4 { get; set; }
        public long? Value5 { get; set; }
        public long? Value6 { get; set; }
    }
}
