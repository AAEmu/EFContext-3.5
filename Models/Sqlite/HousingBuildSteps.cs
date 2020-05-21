namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HousingBuildSteps
    {
        public long Id { get; set; }
        public long? HousingId { get; set; }
        public long? ModelId { get; set; }
        public long? NumActions { get; set; }
        public long? SkillId { get; set; }
        public long? Step { get; set; }

        public virtual Housings Housing { get; set; }
        public virtual Models Model { get; set; }
        public virtual Skills Skill { get; set; }
    }
}
