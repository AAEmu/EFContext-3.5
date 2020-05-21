namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BattleFieldBuffs
    {
        public long? Id { get; set; }
        public long? BattleFieldId { get; set; }
        public long? BuffId { get; set; }
        public long? Value { get; set; }
    }
}
