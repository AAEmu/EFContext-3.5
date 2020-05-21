namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestContextGroupMembers
    {
        public long Id { get; set; }
        public long? ContextId { get; set; }
        public long? QuestContextGroupId { get; set; }

        public virtual QuestContextGroups QuestContextGroup { get; set; }
    }
}
