namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class NpcChatBubbles
    {
        public long Id { get; set; }
        public long? AiEventId { get; set; }
        public string Bubble { get; set; }
        public byte[] ShowUi { get; set; }

        public virtual AiEvents AiEvent { get; set; }
    }
}
