namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncReactDevotes
    {
        public long Id { get; set; }
        public long? Count { get; set; }
        public long? NextPhase { get; set; }
        public long? SkillId { get; set; }
        public string TooltipText { get; set; }

        public virtual Skills Skill { get; set; }
    }
}
