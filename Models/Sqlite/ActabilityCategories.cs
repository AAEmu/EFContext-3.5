namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ActabilityCategories
    {
        public long Id { get; set; }
        public long? GroupId { get; set; }
        public string Name { get; set; }
        public long? VisibleOrder { get; set; }
        public byte[] VisibleUi { get; set; }
    }
}
