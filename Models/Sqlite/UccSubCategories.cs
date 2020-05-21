namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class UccSubCategories
    {
        public string Id { get; set; }
        public string Desc { get; set; }
        public string IsMain { get; set; }
        public string Name { get; set; }
        public string UccCategoryId { get; set; }
    }
}
