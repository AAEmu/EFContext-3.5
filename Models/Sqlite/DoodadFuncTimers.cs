namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncTimers
    {
        public long Id { get; set; }
        public long? Delay { get; set; }
        public byte[] KeepRequester { get; set; }
        public long? NextPhase { get; set; }
        public byte[] ShowEndTime { get; set; }
        public byte[] ShowTip { get; set; }
        public string Tip { get; set; }
    }
}
