namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class UnitModifiers
    {
        public string OwnerType { get; set; }
        public long? OwnerId { get; set; }
        public long? LinearLevelBonus { get; set; }
        public long? UnitAttributeId { get; set; }
        public long? UnitModifierTypeId { get; set; }
        public long? Value { get; set; }
    }
}
