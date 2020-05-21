namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemRndAttrUnitModifierGroups
    {
        public long Id { get; set; }
        public long? ItemRndAttrUnitModifierGroupSetId { get; set; }
        public long? UnitAttributeId { get; set; }
        public long? UnitModifierTypeId { get; set; }
        public long? Weight { get; set; }

        public virtual ItemRndAttrUnitModifierGroupSets ItemRndAttrUnitModifierGroupSet { get; set; }
    }
}
