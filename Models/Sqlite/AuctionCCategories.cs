namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class AuctionCCategories
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public long? ParentCategoryId { get; set; }
    }
}
