namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActObjZoneQuestCompletes
    {
        public long Id { get; set; }
        public long? Count { get; set; }
        public long? QuestActObjAliasId { get; set; }
        public byte[] UseAlias { get; set; }
        public long? ZoneId { get; set; }

        public virtual Zones Zone { get; set; }
    }
}
