namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncFinals
    {
        public long Id { get; set; }
        public long? After { get; set; }
        public long? MaxTime { get; set; }
        public long? MinTime { get; set; }
        public byte[] Respawn { get; set; }
        public byte[] ShowEndTime { get; set; }
        public byte[] ShowTip { get; set; }
        public string Tip { get; set; }
    }
}
