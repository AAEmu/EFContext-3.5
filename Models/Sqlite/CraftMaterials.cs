namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class CraftMaterials
    {
        public long Id { get; set; }
        public long? Amount { get; set; }
        public long? CraftId { get; set; }
        public long? ItemId { get; set; }
        public byte[] MainGrade { get; set; }
        public long? RequireGrade { get; set; }
        public byte[] UpperGrade { get; set; }

        public virtual Crafts Craft { get; set; }
        public virtual ItemTemplate Item { get; set; }
    }
}
