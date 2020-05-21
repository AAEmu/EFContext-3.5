namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class PremiumConfigs
    {
        public long Id { get; set; }
        public long? ConnectPoint { get; set; }
        public long? DeactivatePoint { get; set; }
        public long? DisconnectPoint { get; set; }
        public long? MaxGrade { get; set; }
        public long? MaxPoint { get; set; }
    }
}
