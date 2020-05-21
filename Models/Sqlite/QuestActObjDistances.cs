namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActObjDistances
    {
        public long Id { get; set; }
        public long? Distance { get; set; }
        public long? HighlightDoodadId { get; set; }
        public long? NpcId { get; set; }
        public long? QuestActObjAliasId { get; set; }
        public byte[] UseAlias { get; set; }
        public byte[] Within { get; set; }

        public virtual Npcs Npc { get; set; }
    }
}
