namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class FxShakeCameras
    {
        public long Id { get; set; }
        public double? AngX { get; set; }
        public double? AngY { get; set; }
        public double? AngZ { get; set; }
        public double? Duration { get; set; }
        public double? Frequency { get; set; }
        public double? Randomness { get; set; }
        public double? Range { get; set; }
        public double? ShiftX { get; set; }
        public double? ShiftY { get; set; }
        public double? ShiftZ { get; set; }
    }
}
