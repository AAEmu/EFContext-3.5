namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ReportCrimeEffects
    {
        public long Id { get; set; }
        public long? CrimeKindId { get; set; }
        public long? Value { get; set; }
    }
}
