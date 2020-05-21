namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActObjCompleteQuests
    {
        public long Id { get; set; }
        public byte[] AcceptWith { get; set; }
        public long? QuestActObjAliasId { get; set; }
        public long? QuestId { get; set; }
        public byte[] UseAlias { get; set; }
    }
}
