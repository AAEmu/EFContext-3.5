namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestContextTexts
    {
        public long Id { get; set; }
        public long? QuestContextTextKindId { get; set; }
        public long? QuestContextId { get; set; }
        public string Text { get; set; }

        public virtual QuestContexts QuestContext { get; set; }
    }
}
