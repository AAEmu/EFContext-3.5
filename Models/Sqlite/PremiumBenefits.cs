namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class PremiumBenefits
    {
        public long Id { get; set; }
        public long? GradeId { get; set; }
        public long? IconId { get; set; }
        public long? MaxLabor { get; set; }
        public long? OfflineLabor { get; set; }
        public long? OnlineLabor { get; set; }

        public virtual Icons Icon { get; set; }
    }
}
