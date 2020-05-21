namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class CombatSounds
    {
        public long Id { get; set; }
        public long? FxGroupId { get; set; }
        public long? SoundId { get; set; }
        public long? SourceSoundMaterialId { get; set; }
        public long? TargetSoundMaterialId { get; set; }

        public virtual FxGroups FxGroup { get; set; }
        public virtual Sounds Sound { get; set; }
    }
}
