using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class PrefabModels
    {
        public PrefabModels()
        {
            PrefabElements = new HashSet<PrefabElements>();
        }

        public long Id { get; set; }

        public virtual ICollection<PrefabElements> PrefabElements { get; set; }
    }
}
