using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HeroGrades
    {
        public HeroGrades()
        {
            HeroRewards = new HashSet<HeroRewards>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<HeroRewards> HeroRewards { get; set; }
    }
}
