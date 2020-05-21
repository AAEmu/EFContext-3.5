namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncSiegePeriods
    {
        public long Id { get; set; }
        public byte[] Defense { get; set; }
        public long? NextPhase { get; set; }
        public long? SiegePeriodId { get; set; }
    }
}
