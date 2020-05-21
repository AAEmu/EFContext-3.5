namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class PhysicalExplosionEffects
    {
        public long Id { get; set; }
        public double? HoleSize { get; set; }
        public double? Pressure { get; set; }
        public double? Radius { get; set; }
    }
}
