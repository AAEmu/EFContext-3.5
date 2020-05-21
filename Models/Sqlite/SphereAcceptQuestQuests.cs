namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SphereAcceptQuestQuests
    {
        public long Id { get; set; }
        public long? QuestId { get; set; }
        public long? SphereAcceptQuestId { get; set; }

        public virtual SphereAcceptQuests SphereAcceptQuest { get; set; }
    }
}
