namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class FamilyLevels
    {
        public long Id { get; set; }
        public long? BuffId { get; set; }
        public long? Exp { get; set; }
        public string GradeName { get; set; }
        public long? Level { get; set; }

        public virtual Buffs Buff { get; set; }
    }
}
