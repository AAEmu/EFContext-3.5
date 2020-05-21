namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemDyeings
    {
        public long? ItemId { get; set; }
        public long? DyeingColorId { get; set; }

        public virtual DyeingColors DyeingColor { get; set; }
        public virtual ItemTemplate Item { get; set; }
    }
}
