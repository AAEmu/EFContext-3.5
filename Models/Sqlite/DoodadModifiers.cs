namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadModifiers
    {
        public string OwnerType { get; set; }
        public long? OwnerId { get; set; }
        public long? DoodadAttributeId { get; set; }
        public long? DoodadId { get; set; }
        public long? TagId { get; set; }
        public long? UnitModifierTypeId { get; set; }
        public long? Value { get; set; }

        public virtual Tags Tag { get; set; }
    }
}
