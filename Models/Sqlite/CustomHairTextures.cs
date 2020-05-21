namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class CustomHairTextures
    {
        public long Id { get; set; }
        public string DiffuseTexture { get; set; }
        public string MaskTexture { get; set; }
        public string NormalTexture { get; set; }
        public string SpecularTexture { get; set; }
    }
}
