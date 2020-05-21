namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class IntensifiedExpertLimits
    {
        public long? ExpertLimitId { get; set; }
        public long? ActabilityViewGroupId { get; set; }
        public long? Count { get; set; }

        public virtual ActabilityViewGroups ActabilityViewGroup { get; set; }
        public virtual ExpertLimits ExpertLimit { get; set; }
    }
}
