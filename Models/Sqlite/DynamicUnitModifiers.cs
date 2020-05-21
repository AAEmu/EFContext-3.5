namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DynamicUnitModifiers
    {
        public long Id { get; set; }
        public long? BuffId { get; set; }
        public string FuncType { get; set; }
        public long? FuncId { get; set; }
        public long? UnitAttributeId { get; set; }
        public long? UnitModifierTypeId { get; set; }

        public virtual Buffs Buff { get; set; }
    }
}
