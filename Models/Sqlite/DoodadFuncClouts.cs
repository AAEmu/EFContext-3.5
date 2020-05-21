using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncClouts
    {
        public DoodadFuncClouts()
        {
            DoodadFuncCloutEffects = new HashSet<DoodadFuncCloutEffects>();
        }

        public long Id { get; set; }
        public long? AoeShapeId { get; set; }
        public long? BuffId { get; set; }
        public byte[] CheckNoTargetTagSrc { get; set; }
        public byte[] CheckProjectileHighPriority { get; set; }
        public byte[] CheckTargetTagSrc { get; set; }
        public long? Duration { get; set; }
        public long? FxGroupId { get; set; }
        public long? NextPhase { get; set; }
        public long? ProjectileId { get; set; }
        public byte[] ShowToFriendlyOnly { get; set; }
        public long? TargetBuffTagId { get; set; }
        public long? TargetNoBuffTagId { get; set; }
        public long? TargetRelationId { get; set; }
        public long? Tick { get; set; }
        public byte[] UseOriginSource { get; set; }

        public virtual AoeShapes AoeShape { get; set; }
        public virtual Buffs Buff { get; set; }
        public virtual FxGroups FxGroup { get; set; }
        public virtual Projectiles Projectile { get; set; }
        public virtual ICollection<DoodadFuncCloutEffects> DoodadFuncCloutEffects { get; set; }
    }
}
