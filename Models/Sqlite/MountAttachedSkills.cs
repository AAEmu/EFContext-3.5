namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class MountAttachedSkills
    {
        public long Id { get; set; }
        public long? AttachPointId { get; set; }
        public long? MountSkillId { get; set; }
        public long? SkillId { get; set; }

        public virtual MountSkills MountSkill { get; set; }
        public virtual Skills Skill { get; set; }
    }
}
