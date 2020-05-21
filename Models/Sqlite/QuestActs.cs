namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActs
    {
        public long Id { get; set; }
        public string ActDetailType { get; set; }
        public long? ActDetailId { get; set; }
        public long? QuestComponentId { get; set; }

        public virtual QuestComponents QuestComponent { get; set; }
    }
}
