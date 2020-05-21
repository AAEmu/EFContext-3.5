namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class RecoverExpEffects
    {
        public long Id { get; set; }
        public byte[] NeedLaborPower { get; set; }
        public byte[] NeedMoney { get; set; }
        public byte[] NeedPriest { get; set; }
        public byte[] Penaltied { get; set; }
    }
}
