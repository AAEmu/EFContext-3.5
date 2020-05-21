namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SphereChatBubbles
    {
        public long Id { get; set; }
        public long? Angle { get; set; }
        public long? CameraId { get; set; }
        public string ChangeSpeakerName { get; set; }
        public long? ChatBubbleKindId { get; set; }
        public string Facial { get; set; }
        public byte[] IsStart { get; set; }
        public long? NextBubble { get; set; }
        public long? NpcSpawnerId { get; set; }
        public long? NpcId { get; set; }
        public long? SoundId { get; set; }
        public string Speech { get; set; }
        public long? SphereBubbleId { get; set; }

        public virtual Npcs Npc { get; set; }
        public virtual Sounds Sound { get; set; }
        public virtual SphereBubbles SphereBubble { get; set; }
    }
}
