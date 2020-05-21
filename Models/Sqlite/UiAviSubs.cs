namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class UiAviSubs
    {
        public long Id { get; set; }
        public string FileName { get; set; }
        public string Name { get; set; }
        public long? Priority { get; set; }
        public long? UiAviId { get; set; }

        public virtual UiAvis UiAvi { get; set; }
    }
}
