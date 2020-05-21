using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SlaveInitialItemPacks
    {
        public SlaveInitialItemPacks()
        {
            SlaveInitialItems = new HashSet<SlaveInitialItems>();
            Slaves = new HashSet<Slaves>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SlaveInitialItems> SlaveInitialItems { get; set; }
        public virtual ICollection<Slaves> Slaves { get; set; }
    }
}
