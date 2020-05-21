using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Levels
    {
        public Levels()
        {
            Sounds = new HashSet<Sounds>();
        }

        public long Id { get; set; }
        public long? ExpeditionExp { get; set; }
        public long? ReqItemCount { get; set; }
        public long? ReqItemId { get; set; }
        public long? SkillPoints { get; set; }
        public long? TotalExp { get; set; }
        public long? TotalMateExp { get; set; }

        public virtual ICollection<Sounds> Sounds { get; set; }
    }
}
