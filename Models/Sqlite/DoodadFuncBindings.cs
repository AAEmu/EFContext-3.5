namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncBindings
    {
        public long Id { get; set; }
        public long? DistrictId { get; set; }
        public long? ZoneId { get; set; }

        public virtual Districts District { get; set; }
        public virtual Zones Zone { get; set; }
    }
}
