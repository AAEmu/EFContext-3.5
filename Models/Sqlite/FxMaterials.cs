namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class FxMaterials
    {
        public long Id { get; set; }
        public double? CustomDualMaterialFadeTime { get; set; }
        public long? CustomDualMaterialId { get; set; }

        public virtual CustomDualMaterials CustomDualMaterial { get; set; }
    }
}
