using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class MountSkills
    {
        public MountSkills()
        {
            BuffMountSkills = new HashSet<BuffMountSkills>();
            MountAttachedSkills = new HashSet<MountAttachedSkills>();
            NpcMountSkills = new HashSet<NpcMountSkills>();
            SlaveMountSkills = new HashSet<SlaveMountSkills>();
        }

        public long Id { get; set; }
        public byte[] CheckAttachPoint { get; set; }
        public long? SkillId { get; set; }

        public virtual Skills Skill { get; set; }
        public virtual ICollection<BuffMountSkills> BuffMountSkills { get; set; }
        public virtual ICollection<MountAttachedSkills> MountAttachedSkills { get; set; }
        public virtual ICollection<NpcMountSkills> NpcMountSkills { get; set; }
        public virtual ICollection<SlaveMountSkills> SlaveMountSkills { get; set; }
    }
}
