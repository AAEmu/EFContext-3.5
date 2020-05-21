namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActObjTalks
    {
        public long Id { get; set; }
        public long? HighlightDoodadPhase { get; set; }
        public long? HighlightDoodadId { get; set; }
        public long? ItemId { get; set; }
        public long? NpcId { get; set; }
        public long? QuestActObjAliasId { get; set; }
        public byte[] TeamShare { get; set; }
        public byte[] UseAlias { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual Npcs Npc { get; set; }
    }
}
