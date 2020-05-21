namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HousingGroupCategories
    {
        public long Id { get; set; }
        public long? CategoryId { get; set; }
        public long? HousingGroupId { get; set; }
        public long? MaxConstructCount { get; set; }

        public virtual HousingGroups HousingGroup { get; set; }
    }
}
