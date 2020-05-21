namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActObjExpressFires
    {
        public long Id { get; set; }
        public long? Count { get; set; }
        public long? ExpressKeyId { get; set; }
        public long? NpcGroupId { get; set; }
        public long? QuestActObjAliasId { get; set; }
        public byte[] UseAlias { get; set; }
    }
}
