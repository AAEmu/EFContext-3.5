namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActObjConquestWars
    {
        public long Id { get; set; }
        public long? CompleteRank { get; set; }
        public long? QuestActObjAliasId { get; set; }
        public byte[] UseAlias { get; set; }
        public long? ZoneGroupId { get; set; }

        public virtual ZoneGroups ZoneGroup { get; set; }
    }
}
