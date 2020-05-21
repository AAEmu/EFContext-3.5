namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncClimbs
    {
        public long Id { get; set; }
        public byte[] AllowHorizontalMultiHanger { get; set; }
        public long? ClimbTypeId { get; set; }
    }
}
