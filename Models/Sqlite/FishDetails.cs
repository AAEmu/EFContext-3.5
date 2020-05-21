namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class FishDetails
    {
        public long Id { get; set; }
        public long? ItemId { get; set; }
        public long? MaxLength { get; set; }
        public long? MaxWeight { get; set; }
        public long? MinLength { get; set; }
        public long? MinWeight { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
