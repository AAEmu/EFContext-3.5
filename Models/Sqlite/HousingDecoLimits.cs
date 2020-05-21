using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HousingDecoLimits
    {
        public HousingDecoLimits()
        {
            HousingDecoLimitElems = new HashSet<HousingDecoLimitElems>();
            Housings = new HashSet<Housings>();
        }

        public long Id { get; set; }

        public virtual ICollection<HousingDecoLimitElems> HousingDecoLimitElems { get; set; }
        public virtual ICollection<Housings> Housings { get; set; }
    }
}
