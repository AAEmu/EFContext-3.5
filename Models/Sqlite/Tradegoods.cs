using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Tradegoods
    {
        public Tradegoods()
        {
            TradegoodMaterials = new HashSet<TradegoodMaterials>();
        }

        public long Id { get; set; }
        public long? Count { get; set; }
        public long? DispOrder { get; set; }
        public long? ItemId { get; set; }
        public long? Profit { get; set; }
        public long? Ratio { get; set; }
        public long? TradegoodCategoryId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual ICollection<TradegoodMaterials> TradegoodMaterials { get; set; }
    }
}
