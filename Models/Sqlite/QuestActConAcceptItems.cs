namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActConAcceptItems
    {
        public long Id { get; set; }
        public byte[] Cleanup { get; set; }
        public byte[] DestroyWhenDrop { get; set; }
        public byte[] DropWhenDestroy { get; set; }
        public long? ItemId { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
