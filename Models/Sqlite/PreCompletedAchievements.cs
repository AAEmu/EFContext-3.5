namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class PreCompletedAchievements
    {
        public long Id { get; set; }
        public long? CompletedAchievementId { get; set; }
        public long? MyAchievementId { get; set; }
    }
}
