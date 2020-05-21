using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Effects
    {
        public Effects()
        {
            BuffTickEffects = new HashSet<BuffTickEffects>();
            BuffTriggers = new HashSet<BuffTriggers>();
            DoodadFuncCloutEffects = new HashSet<DoodadFuncCloutEffects>();
            QuestActObjEffectFires = new HashSet<QuestActObjEffectFires>();
            SkillEffects = new HashSet<SkillEffects>();
            TooltipSkillEffects = new HashSet<TooltipSkillEffects>();
        }

        public long Id { get; set; }
        public string ActualType { get; set; }
        public long? ActualId { get; set; }

        public virtual ICollection<BuffTickEffects> BuffTickEffects { get; set; }
        public virtual ICollection<BuffTriggers> BuffTriggers { get; set; }
        public virtual ICollection<DoodadFuncCloutEffects> DoodadFuncCloutEffects { get; set; }
        public virtual ICollection<QuestActObjEffectFires> QuestActObjEffectFires { get; set; }
        public virtual ICollection<SkillEffects> SkillEffects { get; set; }
        public virtual ICollection<TooltipSkillEffects> TooltipSkillEffects { get; set; }
    }
}
