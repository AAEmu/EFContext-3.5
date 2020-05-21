namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActEtcItemObtains
    {
        public long Id { get; set; }
        public byte[] Cleanup { get; set; }
        public long? Count { get; set; }
        public long? HighlightDoodadId { get; set; }
        public long? ItemId { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
