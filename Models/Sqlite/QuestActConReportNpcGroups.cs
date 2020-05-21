namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActConReportNpcGroups
    {
        public long Id { get; set; }
        public long? QuestActObjAliasId { get; set; }
        public long? QuestMonsterGroupId { get; set; }
        public byte[] UseAlias { get; set; }

        public virtual QuestMonsterGroups QuestMonsterGroup { get; set; }
    }
}
