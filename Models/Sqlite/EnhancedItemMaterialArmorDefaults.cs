namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class EnhancedItemMaterialArmorDefaults
    {
        public long Id { get; set; }
        public long? CategoryId { get; set; }
        public long? EnhancedItemMaterialId { get; set; }
        public long? MaxGradeId { get; set; }
        public long? MinGradeId { get; set; }
        public long? SlotTypeId { get; set; }

        public virtual EnhancedItemMaterials EnhancedItemMaterial { get; set; }
    }
}
