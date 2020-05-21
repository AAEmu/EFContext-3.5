namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HousingBindingDoodads
    {
        public long Id { get; set; }
        public long? AttachPointId { get; set; }
        public long? DoodadId { get; set; }
        public byte[] ForceDbSave { get; set; }
        public long? HousingId { get; set; }

        public virtual Housings Housing { get; set; }
    }
}
