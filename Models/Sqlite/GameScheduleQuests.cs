namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class GameScheduleQuests
    {
        public long Id { get; set; }
        public long? GameScheduleId { get; set; }
        public long? QuestId { get; set; }

        public virtual GameSchedules GameSchedule { get; set; }
    }
}
