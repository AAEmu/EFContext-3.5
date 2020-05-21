using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadBundles
    {
        public DoodadBundles()
        {
            DoodadBundleDoodads = new HashSet<DoodadBundleDoodads>();
            Skills = new HashSet<Skills>();
        }

        public long Id { get; set; }

        public virtual ICollection<DoodadBundleDoodads> DoodadBundleDoodads { get; set; }
        public virtual ICollection<Skills> Skills { get; set; }
    }
}
