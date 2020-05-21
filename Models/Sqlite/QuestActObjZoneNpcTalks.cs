namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActObjZoneNpcTalks
    {
        public long Id { get; set; }
        public long? NpcId { get; set; }
        public long? QuestActObjAliasId { get; set; }
        public byte[] UseAlias { get; set; }

        public virtual Npcs Npc { get; set; }
    }
}
