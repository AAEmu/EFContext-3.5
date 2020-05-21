namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemWeapons
    {
        public long Id { get; set; }
        public long? ItemId { get; set; }
        public long? AssetId { get; set; }
        public byte[] BaseEnchantable { get; set; }
        public byte[] BaseEquipment { get; set; }
        public long? ChargeCount { get; set; }
        public long? ChargeLifetime { get; set; }
        public double? DrawnScale { get; set; }
        public long? DurabilityMultiplier { get; set; }
        public long? EisetId { get; set; }
        public long? EnhancedItemMaterialId { get; set; }
        public long? FixedVisualEffectId { get; set; }
        public long? HoldableId { get; set; }
        public long? ItemRndAttrCategoryId { get; set; }
        public long? ModSetId { get; set; }
        public byte[] OrUnitReqs { get; set; }
        public long? RechargeBuffId { get; set; }
        public long? RechargeRestrictItemId { get; set; }
        public long? RechargeRndAttrUnitModifierRestrictItemId { get; set; }
        public byte[] Repairable { get; set; }
        public long? RndAttrUnitModifierLifetime { get; set; }
        public long? SkinKindId { get; set; }
        public byte[] UseAsStat { get; set; }
        public double? WornScale { get; set; }

        public virtual EnhancedItemMaterials EnhancedItemMaterial { get; set; }
        public virtual Holdables Holdable { get; set; }
        public virtual ItemTemplate Item { get; set; }
    }
}
