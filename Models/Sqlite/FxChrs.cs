namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class FxChrs
    {
        public long Id { get; set; }
        public byte[] BindToBoneAfterEnd { get; set; }
        public double? Scale { get; set; }
    }
}
