using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Plots
    {
        public Plots()
        {
            PlotEvents = new HashSet<PlotEvents>();
            Skills = new HashSet<Skills>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long? TargetTypeId { get; set; }

        public virtual ICollection<PlotEvents> PlotEvents { get; set; }
        public virtual ICollection<Skills> Skills { get; set; }
    }
}
