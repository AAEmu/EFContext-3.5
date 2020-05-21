namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActObjCrafts
    {
        public long Id { get; set; }
        public long? Count { get; set; }
        public long? CraftId { get; set; }
        public long? HighlightDoodadPhase { get; set; }
        public long? HighlightDoodadId { get; set; }
        public long? QuestActObjAliasId { get; set; }
        public byte[] UseAlias { get; set; }

        public virtual Crafts Craft { get; set; }
    }
}
