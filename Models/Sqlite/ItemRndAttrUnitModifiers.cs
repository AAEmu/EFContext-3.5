namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemRndAttrUnitModifiers
    {
        public long Id { get; set; }
        public long? GradeId { get; set; }
        public long? GroupId { get; set; }
        public long? Max { get; set; }
        public long? Min { get; set; }
    }
}
