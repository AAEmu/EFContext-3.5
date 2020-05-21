namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActObjItemGathers
    {
        public long Id { get; set; }
        public byte[] Cleanup { get; set; }
        public long? Count { get; set; }
        public byte[] DestroyWhenDrop { get; set; }
        public byte[] DropWhenDestroy { get; set; }
        public long? HighlightDoodadPhase { get; set; }
        public long? HighlightDoodadId { get; set; }
        public long? ItemId { get; set; }
        public long? QuestActObjAliasId { get; set; }
        public byte[] UseAlias { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
