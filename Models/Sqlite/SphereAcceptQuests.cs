using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SphereAcceptQuests
    {
        public SphereAcceptQuests()
        {
            SphereAcceptQuestQuests = new HashSet<SphereAcceptQuestQuests>();
        }

        public long Id { get; set; }

        public virtual ICollection<SphereAcceptQuestQuests> SphereAcceptQuestQuests { get; set; }
    }
}
