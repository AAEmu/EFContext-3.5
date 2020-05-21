namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class AccountAttendanceRewards
    {
        public long Id { get; set; }
        public byte[] AdditionalReward { get; set; }
        public string Comment { get; set; }
        public long? DayCount { get; set; }
        public long? ItemCount { get; set; }
        public long? ItemGradeId { get; set; }
        public long? ItemId { get; set; }
        public long? Month { get; set; }
        public string Name { get; set; }
        public long? Year { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual ItemGrades ItemGrade { get; set; }
    }
}
