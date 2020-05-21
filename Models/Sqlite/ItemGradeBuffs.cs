namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemGradeBuffs
    {
        public long Id { get; set; }
        public long? BuffId { get; set; }
        public long? ItemGradeId { get; set; }
        public long? ItemId { get; set; }

        public virtual Buffs Buff { get; set; }
        public virtual ItemTemplate Item { get; set; }
        public virtual ItemGrades ItemGrade { get; set; }
    }
}
