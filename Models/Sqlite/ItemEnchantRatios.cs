namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemEnchantRatios
    {
        public long? ItemEnchantRatioGroupId { get; set; }
        public long? Grade { get; set; }
        public long? GradeEnchantSuccessRatio { get; set; }
        public long? GradeEnchantGreatSuccessRatio { get; set; }
        public long? GradeEnchantBreakRatio { get; set; }
        public long? GradeEnchantDowngradeRatio { get; set; }
        public long? GradeEnchantCost { get; set; }
        public long? GradeEnchantDowngradeMin { get; set; }
        public long? GradeEnchantDowngradeMax { get; set; }
        public long? CurrencyId { get; set; }

        public virtual ItemEnchantRatioGroups ItemEnchantRatioGroup { get; set; }
    }
}
