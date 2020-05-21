namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncEnterSysInstances
    {
        public long Id { get; set; }
        public long? FactionId { get; set; }
        public byte[] Selective { get; set; }
        public long? ZoneId { get; set; }

        public virtual Zones Zone { get; set; }
    }
}
