namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class GameScheduleDoodads
    {
        public long Id { get; set; }
        public long? DoodadId { get; set; }
        public long? GameScheduleId { get; set; }

        public virtual GameSchedules GameSchedule { get; set; }
    }
}
