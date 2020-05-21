using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class GuardTowerSteps
    {
        public GuardTowerSteps()
        {
            GuardTowerStepConds = new HashSet<GuardTowerStepConds>();
        }

        public long Id { get; set; }
        public long? BuffId { get; set; }
        public long? GuardTowerSettingId { get; set; }
        public long? NumGates { get; set; }
        public long? NumWalls { get; set; }
        public long? Step { get; set; }

        public virtual Buffs Buff { get; set; }
        public virtual GuardTowerSettings GuardTowerSetting { get; set; }
        public virtual ICollection<GuardTowerStepConds> GuardTowerStepConds { get; set; }
    }
}
