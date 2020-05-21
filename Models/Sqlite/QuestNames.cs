namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestNames
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? QuestContextId { get; set; }
        public long? QuestNameKindId { get; set; }

        public virtual QuestContexts QuestContext { get; set; }
    }
}
