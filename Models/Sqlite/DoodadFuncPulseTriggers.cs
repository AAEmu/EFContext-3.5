namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncPulseTriggers
    {
        public long Id { get; set; }
        public byte[] Flag { get; set; }
        public long? NextPhase { get; set; }
    }
}
