namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class RaceTrackShapes
    {
        public long Id { get; set; }
        public long? RaceTrackId { get; set; }
        public long? ShapeOrder { get; set; }
        public long? V1 { get; set; }

        public virtual RaceTracks RaceTrack { get; set; }
    }
}
