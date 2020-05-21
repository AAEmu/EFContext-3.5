namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActConAcceptNpcKills
    {
        public long Id { get; set; }
        public long? NpcId { get; set; }

        public virtual Npcs Npc { get; set; }
    }
}
