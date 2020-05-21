namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncPuzzleIns
    {
        public long Id { get; set; }
        public long? GroupId { get; set; }
        public string Model { get; set; }
        public double? Ratio { get; set; }
    }
}
