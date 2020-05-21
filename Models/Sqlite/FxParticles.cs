namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class FxParticles
    {
        public long Id { get; set; }
        public byte[] InWater { get; set; }
        public double? Scale { get; set; }
        public long? SoundId { get; set; }
        public long? SoundPackId { get; set; }

        public virtual Sounds Sound { get; set; }
        public virtual SoundPacks SoundPack { get; set; }
    }
}
