namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ImprintUccEffects
    {
        public long Id { get; set; }
        public long? ItemId { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
