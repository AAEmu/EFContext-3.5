namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadBundleDoodads
    {
        public long Id { get; set; }
        public long? DoodadBundleId { get; set; }
        public long? DoodadId { get; set; }

        public virtual DoodadBundles DoodadBundle { get; set; }
    }
}
