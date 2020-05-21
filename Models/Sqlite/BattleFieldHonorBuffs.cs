namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BattleFieldHonorBuffs
    {
        public long Id { get; set; }
        public long? BasicValue { get; set; }
        public long? BattleFieldId { get; set; }
        public long? BuffId { get; set; }
        public long? LoseValue { get; set; }
        public long? WinValue { get; set; }

        public virtual BattleFields BattleField { get; set; }
        public virtual Buffs Buff { get; set; }
    }
}
