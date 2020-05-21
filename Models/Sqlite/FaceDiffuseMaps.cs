namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class FaceDiffuseMaps
    {
        public string Id { get; set; }
        public string Diffuse { get; set; }
        public string ModelId { get; set; }
        public string Name { get; set; }
        public string NpcOnly { get; set; }
    }
}
