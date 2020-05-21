namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class EquipItemAttrModifiers
    {
        public long Id { get; set; }
        public string Alias { get; set; }
        public long? DexWeight { get; set; }
        public long? IntWeight { get; set; }
        public long? SpiWeight { get; set; }
        public long? StaWeight { get; set; }
        public long? StrWeight { get; set; }
    }
}
