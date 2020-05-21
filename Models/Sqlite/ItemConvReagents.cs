namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemConvReagents
    {
        public long Id { get; set; }
        public long? GradeId { get; set; }
        public long? ItemConvRpackId { get; set; }
        public long? ItemId { get; set; }
        public long? MaxGradeId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual ItemConvRpacks ItemConvRpack { get; set; }
    }
}
