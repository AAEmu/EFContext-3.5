namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BattleFieldPickBuffs
    {
        public long Id { get; set; }
        public long? BattleFieldId { get; set; }
        public long? BuffId { get; set; }

        public virtual BattleFields BattleField { get; set; }
        public virtual Buffs Buff { get; set; }
    }
}
