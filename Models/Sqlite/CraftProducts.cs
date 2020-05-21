namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class CraftProducts
    {
        public long Id { get; set; }
        public long? Amount { get; set; }
        public long? CraftId { get; set; }
        public long? ItemGradeId { get; set; }
        public long? ItemId { get; set; }
        public long? Rate { get; set; }
        public byte[] ShowLowerCrafts { get; set; }
        public byte[] UseGrade { get; set; }

        public virtual Crafts Craft { get; set; }
        public virtual ItemTemplate Item { get; set; }
        public virtual ItemGrades ItemGrade { get; set; }
    }
}
