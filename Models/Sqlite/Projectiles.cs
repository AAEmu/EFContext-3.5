using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Projectiles
    {
        public Projectiles()
        {
            DoodadFuncClouts = new HashSet<DoodadFuncClouts>();
            DoodadFuncPuzzleOuts = new HashSet<DoodadFuncPuzzleOuts>();
            SkillVisualGroups = new HashSet<SkillVisualGroups>();
            Skills = new HashSet<Skills>();
        }

        public long Id { get; set; }
        public long? DestBoneId { get; set; }
        public long? FxGroupId { get; set; }
        public byte[] IgnoreZRotation { get; set; }
        public byte[] IsPermanent { get; set; }
        public long? ProjPhysicId { get; set; }
        public long? SrcBoneId { get; set; }

        public virtual FxGroups FxGroup { get; set; }
        public virtual ICollection<DoodadFuncClouts> DoodadFuncClouts { get; set; }
        public virtual ICollection<DoodadFuncPuzzleOuts> DoodadFuncPuzzleOuts { get; set; }
        public virtual ICollection<SkillVisualGroups> SkillVisualGroups { get; set; }
        public virtual ICollection<Skills> Skills { get; set; }
    }
}
