namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class FreshnessGroupItems
    {
        public long Id { get; set; }
        public long? FreshnessGroupId { get; set; }
        public long? RewardRate { get; set; }
        public long? Time { get; set; }
        public string Tooltip { get; set; }

        public virtual FreshnessGroups FreshnessGroup { get; set; }
    }
}
