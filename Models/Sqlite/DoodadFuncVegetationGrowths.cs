namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncVegetationGrowths
    {
        public long? Id { get; set; }
        public string StepOneModel { get; set; }
        public long? StepOneStartScale { get; set; }
        public long? StepOneEndScale { get; set; }
        public long? StepOneTime { get; set; }
        public string StepTwoModel { get; set; }
        public long? StepTwoStartScale { get; set; }
        public long? StepTwoEndScale { get; set; }
        public long? StepTwoTime { get; set; }
        public string StepThreeModel { get; set; }
        public long? StepThreeStartScale { get; set; }
        public long? StepThreeEndScale { get; set; }
        public long? StepThreeTime { get; set; }
    }
}
