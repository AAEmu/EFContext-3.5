namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActConAcceptComponents
    {
        public long Id { get; set; }
        public long? QuestContextId { get; set; }

        public virtual QuestContexts QuestContext { get; set; }
    }
}
