namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActObjInviteTeamFactions
    {
        public long Id { get; set; }
        public long? BuffId { get; set; }
        public long? Count { get; set; }
        public long? QuestActObjAliasId { get; set; }
        public long? QuestActObjInviteId { get; set; }
        public byte[] UseAlias { get; set; }

        public virtual Buffs Buff { get; set; }
    }
}
