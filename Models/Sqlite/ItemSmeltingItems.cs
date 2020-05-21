namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemSmeltingItems
    {
        public long Id { get; set; }
        public long? DisplayProb { get; set; }
        public long? ItemGradeId { get; set; }
        public long? ItemSmeltingId { get; set; }
        public long? ItemId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual ItemGrades ItemGrade { get; set; }
        public virtual ItemSmeltings ItemSmelting { get; set; }
    }
}
