namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemAccessories
    {
        public long Id { get; set; }
        public long? ItemId { get; set; }
        public long? ChargeCount { get; set; }
        public long? ChargeLifetime { get; set; }
        public long? DurabilityMultiplier { get; set; }
        public long? EisetId { get; set; }
        public long? ItemRndAttrCategoryId { get; set; }
        public long? ModSetId { get; set; }
        public byte[] OrUnitReqs { get; set; }
        public long? RechargeBuffId { get; set; }
        public long? RechargeRestrictItemId { get; set; }
        public long? RechargeRndAttrUnitModifierRestrictItemId { get; set; }
        public byte[] Repairable { get; set; }
        public long? RndAttrUnitModifierLifetime { get; set; }
        public long? SlotTypeId { get; set; }
        public long? TypeId { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
