namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DistrictReturnPoints
    {
        public long Id { get; set; }
        public long? DistrictId { get; set; }
        public long? FactionId { get; set; }
        public long? ReturnPointId { get; set; }

        public virtual Districts District { get; set; }
        public virtual ReturnPoints ReturnPoint { get; set; }
    }
}
