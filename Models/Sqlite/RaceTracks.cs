using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class RaceTracks
    {
        public RaceTracks()
        {
            RaceTrackShapes = new HashSet<RaceTrackShapes>();
        }

        public long Id { get; set; }
        public long? DoodadGroupId { get; set; }
        public long? DoodadId { get; set; }
        public long? EndBuffId { get; set; }
        public long? EndNpcId { get; set; }
        public string Name { get; set; }
        public long? RaceLoop { get; set; }
        public long? ReadyBuffId { get; set; }
        public long? ReadyDelay { get; set; }
        public long? ReadyNpcId { get; set; }
        public long? RecordMax { get; set; }
        public long? RecordMin { get; set; }
        public long? StartBuffId { get; set; }
        public long? StartDelay { get; set; }
        public long? StartNpcId { get; set; }
        public long? WaitDelay { get; set; }
        public long? ZoneId { get; set; }

        public virtual DoodadGroups DoodadGroup { get; set; }
        public virtual Zones Zone { get; set; }
        public virtual ICollection<RaceTrackShapes> RaceTrackShapes { get; set; }
    }
}
