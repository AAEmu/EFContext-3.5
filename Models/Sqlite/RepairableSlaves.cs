namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class RepairableSlaves
    {
        public long? Id { get; set; }
        public long? RepairSlaveEffectId { get; set; }
        public long? SlaveId { get; set; }
    }
}
