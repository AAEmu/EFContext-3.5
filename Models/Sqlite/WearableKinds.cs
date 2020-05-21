namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class WearableKinds
    {
        public long? ArmorTypeId { get; set; }
        public double? DurabilityRatio { get; set; }
        public long? ExtraDamageBlunt { get; set; }
        public long? ExtraDamagePierce { get; set; }
        public long? ExtraDamageSlash { get; set; }
        public long? FullBuffId { get; set; }
        public long? HalfBuffId { get; set; }
        public long? SoundMaterialId { get; set; }
    }
}
