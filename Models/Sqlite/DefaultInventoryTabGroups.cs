namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DefaultInventoryTabGroups
    {
        public long Id { get; set; }
        public long? DefaultInventoryTabId { get; set; }
        public long? ItemGroupId { get; set; }

        public virtual DefaultInventoryTabs DefaultInventoryTab { get; set; }
        public virtual ItemGroups ItemGroup { get; set; }
    }
}
