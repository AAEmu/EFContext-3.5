using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class AnimActions
    {
        public AnimActions()
        {
            AttachAnims = new HashSet<AttachAnims>();
            Buffs = new HashSet<Buffs>();
            DoodadFuncAttachments = new HashSet<DoodadFuncAttachments>();
            NpcPostures = new HashSet<NpcPostures>();
        }

        public long Id { get; set; }
        public long? ActionStateId { get; set; }
        public string AnimName { get; set; }
        public long? MainhandToolId { get; set; }
        public double? ModelAngle { get; set; }
        public string ModelPath { get; set; }
        public byte[] ModelPhysic { get; set; }
        public double? ModelPosX { get; set; }
        public double? ModelPosY { get; set; }
        public double? ModelPosZ { get; set; }
        public long? MountPoseId { get; set; }
        public string Name { get; set; }
        public byte[] NoRotate { get; set; }
        public long? OffhandToolId { get; set; }

        public virtual MountPoses MountPose { get; set; }
        public virtual ICollection<AttachAnims> AttachAnims { get; set; }
        public virtual ICollection<Buffs> Buffs { get; set; }
        public virtual ICollection<DoodadFuncAttachments> DoodadFuncAttachments { get; set; }
        public virtual ICollection<NpcPostures> NpcPostures { get; set; }
    }
}
