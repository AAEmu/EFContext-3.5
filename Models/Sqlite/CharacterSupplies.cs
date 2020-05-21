namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class CharacterSupplies
    {
        public long Id { get; set; }
        public long? AbilityId { get; set; }
        public long? Amount { get; set; }
        public long? GradeId { get; set; }
        public long? ItemId { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
