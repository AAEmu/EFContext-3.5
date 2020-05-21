namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActConAcceptSpheres
    {
        public long Id { get; set; }
        public long? SphereId { get; set; }

        public virtual Spheres Sphere { get; set; }
    }
}
