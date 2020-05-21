namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class PrefabElements
    {
        public long Id { get; set; }
        public string FilePath { get; set; }
        public long? PrefabModelId { get; set; }
        public long? StateId { get; set; }

        public virtual PrefabModels PrefabModel { get; set; }
    }
}
