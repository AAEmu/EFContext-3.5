namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ConflictZoneQuestCompletions
    {
        public long Id { get; set; }
        public long? ConflictZoneId { get; set; }
        public long? ContextId { get; set; }
    }
}
