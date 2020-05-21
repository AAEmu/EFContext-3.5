namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class CustomFacePresets
    {
        public long Id { get; set; }
        public long? DisplayOrder { get; set; }
        public long? FaceMorphTypeId { get; set; }
        public string IconPath { get; set; }
        public long? ModelId { get; set; }
        public byte[] Modifier { get; set; }
        public string Name { get; set; }

        public virtual Models Model { get; set; }
    }
}
