namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncConditionalUses
    {
        public long Id { get; set; }
        public long? FakeSkillId { get; set; }
        public long? ItemTriggerPhase { get; set; }
        public long? ItemId { get; set; }
        public long? QuestTriggerPhase { get; set; }
        public long? QuestId { get; set; }
        public long? SkillId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual Skills Skill { get; set; }
    }
}
