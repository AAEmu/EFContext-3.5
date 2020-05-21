using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class NpcNicknames
    {
        public NpcNicknames()
        {
            NpcNickBuffs = new HashSet<NpcNickBuffs>();
            Npcs = new HashSet<Npcs>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<NpcNickBuffs> NpcNickBuffs { get; set; }
        public virtual ICollection<Npcs> Npcs { get; set; }
    }
}
