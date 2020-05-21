using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class FxGroups
    {
        public FxGroups()
        {
            Buffs = new HashSet<Buffs>();
            CombatSounds = new HashSet<CombatSounds>();
            DoodadFuncClouts = new HashSet<DoodadFuncClouts>();
            DoodadFuncFxGroupCallbacks = new HashSet<DoodadFuncFxGroupCallbacks>();
            FxGroupFxItems = new HashSet<FxGroupFxItems>();
            Projectiles = new HashSet<Projectiles>();
            SkillVisualGroups = new HashSet<SkillVisualGroups>();
            Skills = new HashSet<Skills>();
        }

        public long Id { get; set; }

        public virtual ICollection<Buffs> Buffs { get; set; }
        public virtual ICollection<CombatSounds> CombatSounds { get; set; }
        public virtual ICollection<DoodadFuncClouts> DoodadFuncClouts { get; set; }
        public virtual ICollection<DoodadFuncFxGroupCallbacks> DoodadFuncFxGroupCallbacks { get; set; }
        public virtual ICollection<FxGroupFxItems> FxGroupFxItems { get; set; }
        public virtual ICollection<Projectiles> Projectiles { get; set; }
        public virtual ICollection<SkillVisualGroups> SkillVisualGroups { get; set; }
        public virtual ICollection<Skills> Skills { get; set; }
    }
}
