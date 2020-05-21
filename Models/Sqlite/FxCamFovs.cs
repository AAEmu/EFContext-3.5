namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class FxCamFovs
    {
        public long Id { get; set; }
        public double? CamFov { get; set; }
        public double? Duration { get; set; }
        public double? FadeIn { get; set; }
        public double? FadeOut { get; set; }
    }
}
