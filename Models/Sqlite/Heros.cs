using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Heros
    {
        public Heros()
        {
            HeroSchedules = new HashSet<HeroSchedules>();
        }

        public long Id { get; set; }
        public long? HeroConditionId { get; set; }

        public virtual HeroConditions HeroCondition { get; set; }
        public virtual ICollection<HeroSchedules> HeroSchedules { get; set; }
    }
}
