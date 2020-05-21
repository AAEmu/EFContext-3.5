namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ZoneClimateElems
    {
        public long Id { get; set; }
        public long? ClimateId { get; set; }
        public long? ZoneClimateId { get; set; }

        public virtual Climates Climate { get; set; }
        public virtual ZoneClimates ZoneClimate { get; set; }
    }
}
