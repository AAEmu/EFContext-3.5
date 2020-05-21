namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActSupplySkills
    {
        public long Id { get; set; }
        public long? SkillId { get; set; }

        public virtual Skills Skill { get; set; }
    }
}
