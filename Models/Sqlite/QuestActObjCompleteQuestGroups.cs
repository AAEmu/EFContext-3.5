namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActObjCompleteQuestGroups
    {
        public long Id { get; set; }
        public byte[] AcceptWith { get; set; }
        public long? QuestActObjAliasId { get; set; }
        public long? QuestContextGroupId { get; set; }
        public byte[] UseAlias { get; set; }

        public virtual QuestContextGroups QuestContextGroup { get; set; }
    }
}
