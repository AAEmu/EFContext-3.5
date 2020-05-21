namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BuffMountSkills
    {
        public long? BuffId { get; set; }
        public long? MountSkillId { get; set; }

        public virtual Buffs Buff { get; set; }
        public virtual MountSkills MountSkill { get; set; }
    }
}
