namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestComponentTexts
    {
        public long Id { get; set; }
        public long? QuestComponentTextKindId { get; set; }
        public long? QuestComponentId { get; set; }
        public string Text { get; set; }

        public virtual QuestComponents QuestComponent { get; set; }
    }
}
