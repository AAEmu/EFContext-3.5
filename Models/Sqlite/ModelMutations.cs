namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ModelMutations
    {
        public long Id { get; set; }
        public long? BaseModelId { get; set; }
        public long? BuffId { get; set; }
        public long? MutatedModelId { get; set; }
        public long? Priority { get; set; }

        public virtual Buffs Buff { get; set; }
    }
}
