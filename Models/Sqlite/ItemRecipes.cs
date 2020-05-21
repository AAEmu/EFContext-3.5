namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemRecipes
    {
        public long? ItemId { get; set; }
        public long? CraftId { get; set; }

        public virtual Crafts Craft { get; set; }
        public virtual ItemTemplate Item { get; set; }
    }
}
