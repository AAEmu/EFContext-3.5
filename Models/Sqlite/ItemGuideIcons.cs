namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemGuideIcons
    {
        public long Id { get; set; }
        public string CategoryType { get; set; }
        public long? CategoryId { get; set; }
        public long? IconId { get; set; }
        public long? ItemGuideId { get; set; }
        public long? ItemImplId { get; set; }

        public virtual Icons Icon { get; set; }
        public virtual ItemGuides ItemGuide { get; set; }
    }
}
