using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemConvSets
    {
        public ItemConvSets()
        {
            ItemConvs = new HashSet<ItemConvs>();
        }

        public long Id { get; set; }
        public string DialogContent { get; set; }
        public string DialogTitle { get; set; }

        public virtual ICollection<ItemConvs> ItemConvs { get; set; }
    }
}
