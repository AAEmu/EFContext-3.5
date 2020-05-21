namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class TradegoodMaterials
    {
        public long Id { get; set; }
        public long? Count { get; set; }
        public long? IconId { get; set; }
        public long? TagId { get; set; }
        public string Text { get; set; }
        public long? TradegoodId { get; set; }

        public virtual Icons Icon { get; set; }
        public virtual Tags Tag { get; set; }
        public virtual Tradegoods Tradegood { get; set; }
    }
}
