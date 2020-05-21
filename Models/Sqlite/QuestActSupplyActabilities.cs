namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActSupplyActabilities
    {
        public long Id { get; set; }
        public long? ActabilityGroupId { get; set; }
        public long? Point { get; set; }

        public virtual ActabilityGroups ActabilityGroup { get; set; }
    }
}
