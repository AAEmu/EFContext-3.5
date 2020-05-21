namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActObjLaborPowers
    {
        public long Id { get; set; }
        public long? ActabilityGroupId { get; set; }
        public long? Count { get; set; }
        public long? QuestActObjAliasId { get; set; }
        public byte[] UseAlias { get; set; }

        public virtual ActabilityGroups ActabilityGroup { get; set; }
    }
}
