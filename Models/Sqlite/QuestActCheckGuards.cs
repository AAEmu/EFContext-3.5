namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActCheckGuards
    {
        public long Id { get; set; }
        public long? NpcId { get; set; }

        public virtual Npcs Npc { get; set; }
    }
}
