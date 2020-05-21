namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HeroSchedules
    {
        public long Id { get; set; }
        public double? End { get; set; }
        public long? EventId { get; set; }
        public long? HeroId { get; set; }
        public double? Start { get; set; }

        public virtual Heros Hero { get; set; }
    }
}
