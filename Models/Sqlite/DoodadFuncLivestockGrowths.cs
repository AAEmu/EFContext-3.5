namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncLivestockGrowths
    {
        public long? Id { get; set; }
        public byte[] NeedFeed { get; set; }
        public long? Hungry { get; set; }
        public long? FullStep { get; set; }
        public string StepOneModel { get; set; }
        public long? StepOneTime { get; set; }
        public string StepTwoModel { get; set; }
        public long? StepTwoTime { get; set; }
        public string StepThreeModel { get; set; }
    }
}
