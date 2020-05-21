namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SlaveInteractionSkills
    {
        public long? SlaveId { get; set; }
        public long? SkillId { get; set; }

        public virtual Skills Skill { get; set; }
        public virtual Slaves Slave { get; set; }
    }
}
