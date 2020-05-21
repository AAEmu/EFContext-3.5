namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class MerchantGoods
    {
        public long? Id { get; set; }
        public long? MerchantPackId { get; set; }
        public long? ItemId { get; set; }
        public long? GradeId { get; set; }
    }
}
