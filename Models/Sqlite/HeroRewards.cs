namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HeroRewards
    {
        public long Id { get; set; }
        public long? HeroGradeId { get; set; }
        public long? ItemCount { get; set; }
        public long? ItemGradeId { get; set; }
        public long? ItemId { get; set; }
        public long? Ranking { get; set; }
        public long? TopFactionId { get; set; }

        public virtual HeroGrades HeroGrade { get; set; }
        public virtual ItemTemplate Item { get; set; }
        public virtual ItemGrades ItemGrade { get; set; }
    }
}
