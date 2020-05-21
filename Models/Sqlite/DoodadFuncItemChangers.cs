namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncItemChangers
    {
        public long Id { get; set; }
        public long? ItemCount { get; set; }
        public long? ItemId { get; set; }
        public long? NextPhase { get; set; }
        public long? SkillId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual Skills Skill { get; set; }
    }
}
