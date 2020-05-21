namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class UccApplicables
    {
        public long Id { get; set; }
        public long? KindId { get; set; }
        public long? ActualId { get; set; }
        public string TooltipMsg { get; set; }
    }
}
