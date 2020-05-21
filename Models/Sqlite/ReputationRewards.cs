namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ReputationRewards
    {
        public long Id { get; set; }
        public long? LeadershipPoint { get; set; }
        public double? Percent { get; set; }
    }
}
