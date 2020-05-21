namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SpecialtyBundleItems
    {
        public long Id { get; set; }
        public long? ItemId { get; set; }
        public long? Profit { get; set; }
        public long? Ratio { get; set; }
        public long? SpecialtyBundleId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual SpecialtyBundles SpecialtyBundle { get; set; }
    }
}
