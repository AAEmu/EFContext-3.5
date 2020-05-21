namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemRndAttrCategories
    {
        public long Id { get; set; }
        public long? CurrencyId { get; set; }
        public string Desc { get; set; }
        public long? MaterialGradeLimit { get; set; }
        public long? MaxEvolvingGrade { get; set; }
        public string Name { get; set; }
        public long? ReRollItemId { get; set; }
    }
}
