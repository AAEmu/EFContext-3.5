using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class NpcInteractionSets
    {
        public NpcInteractionSets()
        {
            NpcInteractions = new HashSet<NpcInteractions>();
            Npcs = new HashSet<Npcs>();
        }

        public long Id { get; set; }

        public virtual ICollection<NpcInteractions> NpcInteractions { get; set; }
        public virtual ICollection<Npcs> Npcs { get; set; }
    }
}
