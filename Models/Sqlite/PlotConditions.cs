namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class PlotConditions
    {
        public long Id { get; set; }
        public long? KindId { get; set; }
        public byte[] NotCondition { get; set; }
        public byte[] OrUnitReqs { get; set; }
        public long? Param1 { get; set; }
        public long? Param2 { get; set; }
        public long? Param3 { get; set; }
    }
}
