namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HeroBonuses
    {
        public long Id { get; set; }
        public long? ItemCount { get; set; }
        public long? ItemGradeId { get; set; }
        public long? ItemId { get; set; }
        public long? LeadershipPoint { get; set; }
        public long? MobilizationOrderCount { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual ItemGrades ItemGrade { get; set; }
    }
}
