using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemSocketChances
    {
        public ItemSocketChances()
        {
            ItemSockets = new HashSet<ItemSockets>();
        }

        public long Id { get; set; }
        public byte[] FailBreak { get; set; }
        public long? CostRatio { get; set; }

        public virtual ICollection<ItemSockets> ItemSockets { get; set; }
    }
}
