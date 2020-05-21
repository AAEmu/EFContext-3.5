namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class GuardTowerStepConds
    {
        public long Id { get; set; }
        public long? Count { get; set; }
        public long? GuardTowerStepId { get; set; }
        public long? HousingPackId { get; set; }
        public string Name { get; set; }

        public virtual GuardTowerSteps GuardTowerStep { get; set; }
        public virtual HousingPacks HousingPack { get; set; }
    }
}
