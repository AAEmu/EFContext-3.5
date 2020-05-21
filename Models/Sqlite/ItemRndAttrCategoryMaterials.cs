namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemRndAttrCategoryMaterials
    {
        public long Id { get; set; }
        public long? ItemRndAttrCategoryId { get; set; }
        public long? MaterialId { get; set; }
    }
}
