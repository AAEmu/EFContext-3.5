namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class NpcMountSkills
    {
        public long? NpcId { get; set; }
        public long? MountSkillId { get; set; }

        public virtual MountSkills MountSkill { get; set; }
        public virtual Npcs Npc { get; set; }
    }
}
