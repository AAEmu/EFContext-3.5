namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActSupplyItems
    {
        public long Id { get; set; }
        public byte[] Cleanup { get; set; }
        public long? Count { get; set; }
        public byte[] DestroyWhenDrop { get; set; }
        public byte[] DropWhenDestroy { get; set; }
        public long? GradeId { get; set; }
        public long? ItemId { get; set; }
        public byte[] ShowActionBar { get; set; }
        public byte[] TryEquip { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
