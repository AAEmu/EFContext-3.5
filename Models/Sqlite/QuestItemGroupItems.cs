namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestItemGroupItems
    {
        public long Id { get; set; }
        public long? ItemId { get; set; }
        public long? QuestItemGroupId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual QuestItemGroups QuestItemGroup { get; set; }
    }
}
