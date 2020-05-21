namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BuffPassiveBuffs
    {
        public long Id { get; set; }
        public long? BuffId { get; set; }
        public long? PassiveBuffId { get; set; }

        public virtual Buffs Buff { get; set; }
        public virtual PassiveBuffs PassiveBuff { get; set; }
    }
}
