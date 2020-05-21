using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Moulds
    {
        public Moulds()
        {
            MouldPackItems = new HashSet<MouldPackItems>();
        }

        public long Id { get; set; }
        public long? CraftId { get; set; }
        public long? Delay { get; set; }

        public virtual Crafts Craft { get; set; }
        public virtual ICollection<MouldPackItems> MouldPackItems { get; set; }
    }
}
