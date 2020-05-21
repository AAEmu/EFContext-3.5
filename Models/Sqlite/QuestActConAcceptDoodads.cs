namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActConAcceptDoodads
    {
        public long Id { get; set; }
        public long? DoodadId { get; set; }
        public long? QuestActObjAliasId { get; set; }
        public byte[] UseAlias { get; set; }
    }
}
