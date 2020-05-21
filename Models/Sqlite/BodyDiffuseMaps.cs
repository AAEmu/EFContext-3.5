namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BodyDiffuseMaps
    {
        public long Id { get; set; }
        public string Diffuse { get; set; }
        public long? ModelId { get; set; }
        public string Name { get; set; }

        public virtual Models Model { get; set; }
    }
}
