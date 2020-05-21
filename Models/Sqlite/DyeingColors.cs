using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DyeingColors
    {
        public DyeingColors()
        {
            ItemDyeings = new HashSet<ItemDyeings>();
        }

        public long Id { get; set; }
        public long? ColorRgb { get; set; }

        public virtual ICollection<ItemDyeings> ItemDyeings { get; set; }
    }
}
