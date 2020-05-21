namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemConvProducts
    {
        public long Id { get; set; }
        public long? ItemConvPpackId { get; set; }
        public long? ItemGradeId { get; set; }
        public long? ItemId { get; set; }
        public long? Max { get; set; }
        public long? Min { get; set; }
        public long? Weight { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual ItemConvPpacks ItemConvPpack { get; set; }
        public virtual ItemGrades ItemGrade { get; set; }
    }
}
