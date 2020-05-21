namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class FxGroupFxItems
    {
        public long? FxGroupId { get; set; }
        public long? FxItemId { get; set; }

        public virtual FxGroups FxGroup { get; set; }
        public virtual FxItems FxItem { get; set; }
    }
}
