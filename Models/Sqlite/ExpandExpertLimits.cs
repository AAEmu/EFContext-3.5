namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ExpandExpertLimits
    {
        public long? ExpandCount { get; set; }
        public long? LifePoint { get; set; }
        public long? ItemId { get; set; }
        public long? ItemCount { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
