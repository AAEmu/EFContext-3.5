namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SubZones
    {
        public long Id { get; set; }
        public double? H { get; set; }
        public long? Idx { get; set; }
        public long? LinkedZoneGroupId { get; set; }
        public string Name { get; set; }
        public long? ParentSubZoneId { get; set; }
        public long? SoundId { get; set; }
        public long? SoundPackId { get; set; }
        public double? W { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }

        public virtual Sounds Sound { get; set; }
        public virtual SoundPacks SoundPack { get; set; }
    }
}
