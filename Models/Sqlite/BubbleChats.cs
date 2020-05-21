namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BubbleChats
    {
        public long Id { get; set; }
        public long? Angle { get; set; }
        public long? BubbleId { get; set; }
        public long? CameraId { get; set; }
        public string ChangeSpeakerName { get; set; }
        public long? DoodadId { get; set; }
        public string Facial { get; set; }
        public long? KindId { get; set; }
        public long? Next { get; set; }
        public long? NpcSpawnerId { get; set; }
        public long? NpcId { get; set; }
        public long? SoundId { get; set; }
        public string Speech { get; set; }
        public byte[] Start { get; set; }
        public long? VoiceId { get; set; }

        public virtual Bubbles Bubble { get; set; }
        public virtual Npcs Npc { get; set; }
        public virtual Sounds Sound { get; set; }
    }
}
