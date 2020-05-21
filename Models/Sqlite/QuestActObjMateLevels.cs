namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActObjMateLevels
    {
        public long Id { get; set; }
        public byte[] Cleanup { get; set; }
        public long? ItemId { get; set; }
        public long? Level { get; set; }
        public long? QuestActObjAliasId { get; set; }
        public byte[] UseAlias { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
