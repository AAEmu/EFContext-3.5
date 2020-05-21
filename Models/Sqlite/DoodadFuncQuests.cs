namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncQuests
    {
        public long Id { get; set; }
        public long? QuestKindId { get; set; }
        public long? QuestId { get; set; }
    }
}
