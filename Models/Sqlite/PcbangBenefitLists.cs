namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class PcbangBenefitLists
    {
        public long Id { get; set; }
        public long? GroupIdx { get; set; }
        public string Kind { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }
    }
}
