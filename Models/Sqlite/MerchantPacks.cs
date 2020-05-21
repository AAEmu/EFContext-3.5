namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class MerchantPacks
    {
        public long? PackId { get; set; }
        public long? KindId { get; set; }
        public long? ItemId { get; set; }
        public long? GradeId { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
