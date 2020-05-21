namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemGradeEnchantingSupports
    {
        public long? ItemId { get; set; }
        public long? AddBreakMul { get; set; }
        public long? AddBreakRatio { get; set; }
        public long? AddDowngradeMul { get; set; }
        public long? AddDowngradeRatio { get; set; }
        public long? AddGreatSuccessGrade { get; set; }
        public long? AddGreatSuccessMul { get; set; }
        public long? AddGreatSuccessRatio { get; set; }
        public long? AddSuccessMul { get; set; }
        public long? AddSuccessRatio { get; set; }
        public long? Icons { get; set; }
        public long? ImplFlags { get; set; }
        public long? RequireGradeMax { get; set; }
        public long? RequireGradeMin { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
