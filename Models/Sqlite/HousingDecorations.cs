namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HousingDecorations
    {
        public long Id { get; set; }
        public long? ActabilityGroupId { get; set; }
        public long? ActabilityUp { get; set; }
        public byte[] AllowMeshOnGarden { get; set; }
        public byte[] AllowOnCeiling { get; set; }
        public byte[] AllowOnFloor { get; set; }
        public byte[] AllowOnWall { get; set; }
        public byte[] AllowPivotOnGarden { get; set; }
        public long? DecoActabilityGroupId { get; set; }
        public long? DoodadId { get; set; }
        public byte[] VerticalAligned { get; set; }

        public virtual ActabilityGroups ActabilityGroup { get; set; }
        public virtual DecoActabilityGroups DecoActabilityGroup { get; set; }
    }
}
