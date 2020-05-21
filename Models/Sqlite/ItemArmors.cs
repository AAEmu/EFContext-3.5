namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemArmors
    {
        public long Id { get; set; }
        public long? ItemId { get; set; }
        public long? Asset2Id { get; set; }
        public long? AssetId { get; set; }
        public byte[] BaseEnchantable { get; set; }
        public byte[] BaseEquipment { get; set; }
        public long? ChargeCount { get; set; }
        public long? ChargeLifetime { get; set; }
        public long? DurabilityMultiplier { get; set; }
        public long? EisetId { get; set; }
        public long? EnhancedItemMaterialId { get; set; }
        public byte[] EquipOnlyHasArmorVisual { get; set; }
        public byte[] InvisibleAsset { get; set; }
        public long? ItemRndAttrCategoryId { get; set; }
        public long? ModSetId { get; set; }
        public string NoVisualErrorMessage { get; set; }
        public byte[] OrUnitReqs { get; set; }
        public long? RechargeBuffId { get; set; }
        public long? RechargeRestrictItemId { get; set; }
        public long? RechargeRndAttrUnitModifierRestrictItemId { get; set; }
        public byte[] Repairable { get; set; }
        public long? RndAttrUnitModifierLifetime { get; set; }
        public long? SkinKindId { get; set; }
        public long? SlotTypeId { get; set; }
        public long? TypeId { get; set; }
        public byte[] UseAsStat { get; set; }

        public virtual EnhancedItemMaterials EnhancedItemMaterial { get; set; }
        public virtual ItemTemplate Item { get; set; }
    }
}
