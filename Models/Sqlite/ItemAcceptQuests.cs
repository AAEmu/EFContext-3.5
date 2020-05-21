namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemAcceptQuests
    {
        public long? ItemId { get; set; }
        public long? QuestId { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
