using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DecoActabilityGroups
    {
        public DecoActabilityGroups()
        {
            HousingDecoLimitElems = new HashSet<HousingDecoLimitElems>();
            HousingDecorations = new HashSet<HousingDecorations>();
        }

        public long Id { get; set; }
        public byte[] CountRule { get; set; }
        public string Name { get; set; }

        public virtual ICollection<HousingDecoLimitElems> HousingDecoLimitElems { get; set; }
        public virtual ICollection<HousingDecorations> HousingDecorations { get; set; }
    }
}
