namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BuffVisualChanges
    {
        public long Id { get; set; }
        public long? ApplyActualId { get; set; }
        public long? ApplyTypeId { get; set; }
        public long? BuffTagId { get; set; }
        public long? Priority { get; set; }
        public long? VisualActualId { get; set; }
        public long? VisualTypeId { get; set; }
    }
}
