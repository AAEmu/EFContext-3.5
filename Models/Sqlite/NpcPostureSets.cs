using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class NpcPostureSets
    {
        public NpcPostureSets()
        {
            NpcPostures = new HashSet<NpcPostures>();
            Npcs = new HashSet<Npcs>();
        }

        public long Id { get; set; }
        public long? QuestAnimActionId { get; set; }

        public virtual ICollection<NpcPostures> NpcPostures { get; set; }
        public virtual ICollection<Npcs> Npcs { get; set; }
    }
}
