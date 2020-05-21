namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SphereQuests
    {
        public long Id { get; set; }
        public long? QuestTriggerId { get; set; }
        public long? QuestId { get; set; }
    }
}
