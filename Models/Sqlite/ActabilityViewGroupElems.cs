namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ActabilityViewGroupElems
    {
        public long? ActabilityGroupId { get; set; }
        public long? ActabilityViewGroupId { get; set; }
        public long? VisibleOrder { get; set; }

        public virtual ActabilityGroups ActabilityGroup { get; set; }
        public virtual ActabilityViewGroups ActabilityViewGroup { get; set; }
    }
}
