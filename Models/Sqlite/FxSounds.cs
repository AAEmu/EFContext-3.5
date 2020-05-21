namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class FxSounds
    {
        public long Id { get; set; }
        public long? SoundId { get; set; }

        public virtual Sounds Sound { get; set; }
    }
}
