namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class GameScheduleSpawners
    {
        public long Id { get; set; }
        public long? GameScheduleId { get; set; }
        public long? SpawnerId { get; set; }

        public virtual GameSchedules GameSchedule { get; set; }
    }
}
