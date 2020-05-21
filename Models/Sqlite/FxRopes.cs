namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class FxRopes
    {
        public long Id { get; set; }
        public string AnchorModelPath { get; set; }
        public byte[] AttachmentCollision { get; set; }
        public byte[] Collision { get; set; }
        public string LauncherModelPath { get; set; }
        public double? Length { get; set; }
        public string Material { get; set; }
        public long? PhyscisSegment { get; set; }
        public long? Segment { get; set; }
        public long? SideCount { get; set; }
        public byte[] Smooth { get; set; }
        public byte[] Subdivide { get; set; }
        public double? Thickness { get; set; }
    }
}
