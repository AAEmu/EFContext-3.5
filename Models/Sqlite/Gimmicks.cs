using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Gimmicks
    {
        public Gimmicks()
        {
            DoodadFuncSpawnGimmicks = new HashSet<DoodadFuncSpawnGimmicks>();
            SpawnGimmickEffects = new HashSet<SpawnGimmickEffects>();
        }

        public long Id { get; set; }
        public double? AirResistance { get; set; }
        public double? CollisionMinSpeed { get; set; }
        public long? CollisionSkillId { get; set; }
        public byte[] CollisionUnitOnly { get; set; }
        public double? Damping { get; set; }
        public double? Density { get; set; }
        public byte[] DisappearByCollision { get; set; }
        public long? FadeInDuration { get; set; }
        public long? FadeOutDuration { get; set; }
        public double? FreeFallDamping { get; set; }
        public byte[] Graspable { get; set; }
        public double? Gravity { get; set; }
        public long? LifeTime { get; set; }
        public double? Mass { get; set; }
        public string ModelPath { get; set; }
        public string Name { get; set; }
        public byte[] NoGroundCollider { get; set; }
        public byte[] PushableByPlayer { get; set; }
        public long? SkillDelay { get; set; }
        public long? SkillId { get; set; }
        public long? SpawnDelay { get; set; }
        public double? WaterDamping { get; set; }
        public double? WaterDensity { get; set; }
        public double? WaterResistance { get; set; }

        public virtual Skills Skill { get; set; }
        public virtual ICollection<DoodadFuncSpawnGimmicks> DoodadFuncSpawnGimmicks { get; set; }
        public virtual ICollection<SpawnGimmickEffects> SpawnGimmickEffects { get; set; }
    }
}
