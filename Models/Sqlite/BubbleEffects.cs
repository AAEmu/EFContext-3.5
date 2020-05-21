namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BubbleEffects
    {
        public long Id { get; set; }
        public long? KindId { get; set; }
        public string Speech { get; set; }
    }
}
