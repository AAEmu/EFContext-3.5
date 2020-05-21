namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class AnimRules
    {
        public long Id { get; set; }
        public long? Before { get; set; }
        public long? BeforeOperatorId { get; set; }
        public long? DefaultOperatorId { get; set; }
        public long? FirstCategoryId { get; set; }
        public long? SecondCategoryId { get; set; }
    }
}
