namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class LocalDevelopments
    {
        public long Id { get; set; }
        public long? DoodadAlmightyId { get; set; }
        public long? DoodadPhase0 { get; set; }
        public long? DoodadPhase1 { get; set; }
        public long? DoodadPhase2 { get; set; }
        public long? DoodadPhase3 { get; set; }
        public long? ZoneGroupId { get; set; }
        public string PhaseEffect0 { get; set; }
        public string PhaseEffect1 { get; set; }
        public string PhaseEffect2 { get; set; }
        public string PhaseEffect3 { get; set; }
        public long? FactionId { get; set; }

        public virtual ZoneGroups ZoneGroup { get; set; }
    }
}
