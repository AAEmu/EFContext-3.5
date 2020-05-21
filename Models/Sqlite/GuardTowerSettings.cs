using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class GuardTowerSettings
    {
        public GuardTowerSettings()
        {
            GuardTowerSteps = new HashSet<GuardTowerSteps>();
            Housings = new HashSet<Housings>();
        }

        public long Id { get; set; }
        public long? InitialBuffId { get; set; }
        public long? MaxDominionBuildings { get; set; }
        public long? MaxGates { get; set; }
        public long? MaxKeeps { get; set; }
        public long? MaxWalls { get; set; }
        public long? RadiusDeclare { get; set; }
        public long? RadiusDominion { get; set; }
        public long? RadiusOffenseHq { get; set; }
        public long? RadiusSiege { get; set; }

        public virtual ICollection<GuardTowerSteps> GuardTowerSteps { get; set; }
        public virtual ICollection<Housings> Housings { get; set; }
    }
}
