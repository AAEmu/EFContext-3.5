namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SoundPackItems
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? SoundId { get; set; }
        public long? SoundPackId { get; set; }

        public virtual Sounds Sound { get; set; }
        public virtual SoundPacks SoundPack { get; set; }
    }
}
