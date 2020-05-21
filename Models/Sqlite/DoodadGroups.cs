using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadGroups
    {
        public DoodadGroups()
        {
            RaceTracks = new HashSet<RaceTracks>();
        }

        public long Id { get; set; }
        public long? GuardOnFieldTime { get; set; }
        public byte[] IsExport { get; set; }
        public byte[] RemovedByHouse { get; set; }

        public virtual ICollection<RaceTracks> RaceTracks { get; set; }
    }
}
