using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class TowerDefs
    {
        public TowerDefs()
        {
            TowerDefProgs = new HashSet<TowerDefProgs>();
        }

        public long Id { get; set; }
        public byte[] BroadcastEventToWholeSeamlessWorld { get; set; }
        public string ColorEnd { get; set; }
        public string ColorProgress { get; set; }
        public string ColorStart { get; set; }
        public string EndMsg { get; set; }
        public double? FirstWaveAfter { get; set; }
        public double? ForceEndTime { get; set; }
        public string IconKey { get; set; }
        public long? KillNpcCount { get; set; }
        public long? KillNpcId { get; set; }
        public double? OperationTimeLimit { get; set; }
        public long? StartDayOfWeekBit { get; set; }
        public long? StartHour { get; set; }
        public long? StartMinute { get; set; }
        public string StartMsg { get; set; }
        public long? TargetNpcSpawnerId { get; set; }
        public string TitleMsg { get; set; }
        public double? Tod { get; set; }
        public long? TodDayInterval { get; set; }

        public virtual ICollection<TowerDefProgs> TowerDefProgs { get; set; }
    }
}
