namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncRequireQuests
    {
        public long Id { get; set; }
        public long? QuestId { get; set; }
        public long? WiId { get; set; }
    }
}
