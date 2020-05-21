namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class MerchantPriceRatios
    {
        public long? NpcId { get; set; }
        public long? Ratio { get; set; }
        public long? TradegoodSaleRatio { get; set; }

        public virtual Npcs Npc { get; set; }
    }
}
