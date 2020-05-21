namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActConAcceptNpcGroups
    {
        public long Id { get; set; }
        public long? QuestMonsterGroupId { get; set; }

        public virtual QuestMonsterGroups QuestMonsterGroup { get; set; }
    }
}
