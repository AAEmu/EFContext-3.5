namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActObjInteractions
    {
        public long Id { get; set; }
        public long? Count { get; set; }
        public long? DoodadId { get; set; }
        public long? HighlightDoodadPhase { get; set; }
        public long? HighlightDoodadId { get; set; }
        public long? Phase { get; set; }
        public long? QuestActObjAliasId { get; set; }
        public long? QuestDoodadGroupId { get; set; }
        public byte[] TeamShare { get; set; }
        public byte[] UseAlias { get; set; }
        public long? WiId { get; set; }

        public virtual QuestDoodadGroups QuestDoodadGroup { get; set; }
    }
}
