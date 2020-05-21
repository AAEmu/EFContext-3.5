namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActConAcceptBuffs
    {
        public long Id { get; set; }
        public long? BuffId { get; set; }

        public virtual Buffs Buff { get; set; }
    }
}
