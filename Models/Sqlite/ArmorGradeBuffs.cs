namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ArmorGradeBuffs
    {
        public long Id { get; set; }
        public long? ArmorTypeId { get; set; }
        public long? BuffId { get; set; }
        public long? ItemGradeId { get; set; }

        public virtual Buffs Buff { get; set; }
        public virtual ItemGrades ItemGrade { get; set; }
    }
}
