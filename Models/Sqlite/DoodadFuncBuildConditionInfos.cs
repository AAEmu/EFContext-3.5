namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncBuildConditionInfos
    {
        public long Id { get; set; }
        public string Effect { get; set; }
        public string Explanation { get; set; }
        public byte[] IsDevote { get; set; }
        public byte[] IsEnd { get; set; }
        public string Tooltip { get; set; }
    }
}
