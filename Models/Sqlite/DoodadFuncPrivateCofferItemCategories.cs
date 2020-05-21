namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncPrivateCofferItemCategories
    {
        public long Id { get; set; }
        public long? DoodadFuncPrivateCofferId { get; set; }
        public long? ItemCategoryId { get; set; }

        public virtual DoodadFuncPrivateCoffers DoodadFuncPrivateCoffer { get; set; }
    }
}
