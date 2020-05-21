using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SlaveCollisionDamages
    {
        public SlaveCollisionDamages()
        {
            Slaves = new HashSet<Slaves>();
        }

        public long Id { get; set; }
        public double? BottomGain { get; set; }
        public double? FrontGain { get; set; }
        public double? RearGain { get; set; }
        public double? SideGain { get; set; }

        public virtual ICollection<Slaves> Slaves { get; set; }
    }
}
