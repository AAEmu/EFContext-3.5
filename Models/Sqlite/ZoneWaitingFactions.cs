namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ZoneWaitingFactions
    {
        public long Id { get; set; }
        public long? InReturnId { get; set; }
        public long? MemberNum { get; set; }
        public long? OutReturnId { get; set; }
        public long? SystemFactionId { get; set; }
        public long? ZoneWaitingId { get; set; }

        public virtual SystemFactions SystemFaction { get; set; }
        public virtual ZoneWaitings ZoneWaiting { get; set; }
    }
}
