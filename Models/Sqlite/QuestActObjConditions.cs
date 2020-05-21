namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActObjConditions
    {
        public long Id { get; set; }
        public long? ConditionId { get; set; }
        public long? QuestActObjAliasId { get; set; }
        public long? QuestContextId { get; set; }
        public byte[] UseAlias { get; set; }

        public virtual QuestContexts QuestContext { get; set; }
    }
}
