using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class PremiumGrades
    {
        public PremiumGrades()
        {
            PcbangBuffs = new HashSet<PcbangBuffs>();
        }

        public long Id { get; set; }
        public long? GradeId { get; set; }
        public long? Point { get; set; }

        public virtual ICollection<PcbangBuffs> PcbangBuffs { get; set; }
    }
}
