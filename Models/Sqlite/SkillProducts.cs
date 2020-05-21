namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SkillProducts
    {
        public long Id { get; set; }
        public long? Amount { get; set; }
        public long? ItemId { get; set; }
        public long? SkillId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual Skills Skill { get; set; }
    }
}
