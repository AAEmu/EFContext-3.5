using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class GameSchedules
    {
        public GameSchedules()
        {
            GameScheduleDoodads = new HashSet<GameScheduleDoodads>();
            GameScheduleQuests = new HashSet<GameScheduleQuests>();
            GameScheduleSpawners = new HashSet<GameScheduleSpawners>();
        }

        public long Id { get; set; }
        public long? DayOfWeekId { get; set; }
        public long? EdDay { get; set; }
        public long? EdHour { get; set; }
        public long? EdMin { get; set; }
        public long? EdMonth { get; set; }
        public long? EdYear { get; set; }
        public long? EndTime { get; set; }
        public long? EndTimeMin { get; set; }
        public string Name { get; set; }
        public long? StDay { get; set; }
        public long? StHour { get; set; }
        public long? StMin { get; set; }
        public long? StMonth { get; set; }
        public long? StYear { get; set; }
        public long? StartTime { get; set; }
        public long? StartTimeMin { get; set; }

        public virtual ICollection<GameScheduleDoodads> GameScheduleDoodads { get; set; }
        public virtual ICollection<GameScheduleQuests> GameScheduleQuests { get; set; }
        public virtual ICollection<GameScheduleSpawners> GameScheduleSpawners { get; set; }
    }
}
