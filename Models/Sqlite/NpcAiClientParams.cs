using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class NpcAiClientParams
    {
        public NpcAiClientParams()
        {
            Npcs = new HashSet<Npcs>();
        }

        public long Id { get; set; }
        public string AiParam { get; set; }

        public virtual ICollection<Npcs> Npcs { get; set; }
    }
}
