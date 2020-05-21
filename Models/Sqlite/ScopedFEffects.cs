namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ScopedFEffects
    {
        public long Id { get; set; }
        public long? DoodadId { get; set; }
        public string Key { get; set; }
        public long? Range { get; set; }
    }
}
