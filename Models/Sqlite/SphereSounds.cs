namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SphereSounds
    {
        public long Id { get; set; }
        public byte[] Broadcast { get; set; }
        public long? SoundId { get; set; }

        public virtual Sounds Sound { get; set; }
    }
}
