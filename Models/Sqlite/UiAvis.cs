using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class UiAvis
    {
        public UiAvis()
        {
            UiAviSubs = new HashSet<UiAviSubs>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long? Priority { get; set; }

        public virtual ICollection<UiAviSubs> UiAviSubs { get; set; }
    }
}
