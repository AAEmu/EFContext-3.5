namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActConAcceptNpcEmotions
    {
        public long Id { get; set; }
        public string Emotion { get; set; }
        public long? NpcId { get; set; }

        public virtual Npcs Npc { get; set; }
    }
}
