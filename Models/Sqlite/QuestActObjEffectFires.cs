namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActObjEffectFires
    {
        public long Id { get; set; }
        public long? Count { get; set; }
        public long? EffectId { get; set; }
        public long? QuestActObjAliasId { get; set; }
        public byte[] UseAlias { get; set; }

        public virtual Effects Effect { get; set; }
    }
}
