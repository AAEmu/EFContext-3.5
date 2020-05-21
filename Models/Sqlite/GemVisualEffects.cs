using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class GemVisualEffects
    {
        public GemVisualEffects()
        {
            ItemEnchantingGems = new HashSet<ItemEnchantingGems>();
        }

        public long Id { get; set; }
        public string Filename { get; set; }

        public virtual ICollection<ItemEnchantingGems> ItemEnchantingGems { get; set; }
    }
}
