using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ActabilityViewGroups
    {
        public ActabilityViewGroups()
        {
            ActabilityViewGroupElems = new HashSet<ActabilityViewGroupElems>();
            IntensifiedExpertLimits = new HashSet<IntensifiedExpertLimits>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long? VisibleOrder { get; set; }

        public virtual ICollection<ActabilityViewGroupElems> ActabilityViewGroupElems { get; set; }
        public virtual ICollection<IntensifiedExpertLimits> IntensifiedExpertLimits { get; set; }
    }
}
