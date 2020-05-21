namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActObjDoodadPhaseChecks
    {
        public long Id { get; set; }
        public long? DoodadId { get; set; }
        public long? Phase1 { get; set; }
        public long? Phase2 { get; set; }
        public long? QuestActObjAliasId { get; set; }
        public byte[] UseAlias { get; set; }
    }
}
