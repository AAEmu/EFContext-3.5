namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemEnchantRatioItems
    {
        public long? ItemEnchantRatioGroupId { get; set; }
        public long? ItemId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual ItemEnchantRatioGroups ItemEnchantRatioGroup { get; set; }
    }
}
