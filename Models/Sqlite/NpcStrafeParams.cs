using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class NpcStrafeParams
    {
        public NpcStrafeParams()
        {
            Npcs = new HashSet<Npcs>();
        }

        public long Id { get; set; }
        public double? EndDistance { get; set; }
        public double? StartDistance { get; set; }
        public byte[] UseDirectDistance { get; set; }

        public virtual ICollection<Npcs> Npcs { get; set; }
    }
}
