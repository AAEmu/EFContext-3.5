namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BuffEffects
    {
        public long Id { get; set; }
        public long? AbLevel { get; set; }
        public long? BuffId { get; set; }
        public long? Chance { get; set; }
        public long? Stack { get; set; }

        public virtual Buffs Buff { get; set; }
    }
}
