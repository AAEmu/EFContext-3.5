namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class PriestBuffs
    {
        public long Id { get; set; }
        public long? BuffId { get; set; }
        public long? Cost { get; set; }
        public long? Position { get; set; }

        public virtual Buffs Buff { get; set; }
    }
}
