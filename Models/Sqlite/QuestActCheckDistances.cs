namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActCheckDistances
    {
        public long Id { get; set; }
        public long? Distance { get; set; }
        public long? NpcId { get; set; }
        public byte[] Within { get; set; }

        public virtual Npcs Npc { get; set; }
    }
}
