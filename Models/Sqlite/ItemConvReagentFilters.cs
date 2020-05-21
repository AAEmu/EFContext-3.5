namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemConvReagentFilters
    {
        public long Id { get; set; }
        public long? ItemConvRpackId { get; set; }
        public long? ItemGradeId { get; set; }
        public long? ItemImplId { get; set; }
        public long? MaxItemGradeId { get; set; }
        public long? MaxLevel { get; set; }
        public long? MinLevel { get; set; }

        public virtual ItemConvRpacks ItemConvRpack { get; set; }
        public virtual ItemGrades ItemGrade { get; set; }
    }
}
