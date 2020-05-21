namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SlaveMountSkills
    {
        public long? SlaveId { get; set; }
        public long? MountSkillId { get; set; }

        public virtual MountSkills MountSkill { get; set; }
        public virtual Slaves Slave { get; set; }
    }
}
