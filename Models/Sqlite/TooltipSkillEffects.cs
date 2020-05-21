namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class TooltipSkillEffects
    {
        public long Id { get; set; }
        public long? EffectId { get; set; }
        public long? SkillId { get; set; }

        public virtual Effects Effect { get; set; }
        public virtual Skills Skill { get; set; }
    }
}
