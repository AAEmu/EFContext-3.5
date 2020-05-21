using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class TowerDefProgs
    {
        public TowerDefProgs()
        {
            TowerDefProgSpawnTargets = new HashSet<TowerDefProgSpawnTargets>();
        }

        public long Id { get; set; }
        public byte[] CondCompByAnd { get; set; }
        public double? CondToNextTime { get; set; }
        public string Msg { get; set; }
        public long? TowerDefId { get; set; }

        public virtual TowerDefs TowerDef { get; set; }
        public virtual ICollection<TowerDefProgSpawnTargets> TowerDefProgSpawnTargets { get; set; }
    }
}
