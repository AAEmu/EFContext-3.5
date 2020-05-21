using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Tags
    {
        public Tags()
        {
            BattleFieldBannedTags = new HashSet<BattleFieldBannedTags>();
            BuffModifiers = new HashSet<BuffModifiers>();
            BuffUnitModifiers = new HashSet<BuffUnitModifiers>();
            DoodadFuncConsumeChangers = new HashSet<DoodadFuncConsumeChangers>();
            DoodadFuncNpcInteractionRelays = new HashSet<DoodadFuncNpcInteractionRelays>();
            DoodadModifiers = new HashSet<DoodadModifiers>();
            SkillModifiers = new HashSet<SkillModifiers>();
            TaggedBuffs = new HashSet<TaggedBuffs>();
            TaggedItems = new HashSet<TaggedItems>();
            TaggedNpcs = new HashSet<TaggedNpcs>();
            TaggedSkills = new HashSet<TaggedSkills>();
            TradegoodMaterials = new HashSet<TradegoodMaterials>();
            ZoneGroupBannedTags = new HashSet<ZoneGroupBannedTags>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BattleFieldBannedTags> BattleFieldBannedTags { get; set; }
        public virtual ICollection<BuffModifiers> BuffModifiers { get; set; }
        public virtual ICollection<BuffUnitModifiers> BuffUnitModifiers { get; set; }
        public virtual ICollection<DoodadFuncConsumeChangers> DoodadFuncConsumeChangers { get; set; }
        public virtual ICollection<DoodadFuncNpcInteractionRelays> DoodadFuncNpcInteractionRelays { get; set; }
        public virtual ICollection<DoodadModifiers> DoodadModifiers { get; set; }
        public virtual ICollection<SkillModifiers> SkillModifiers { get; set; }
        public virtual ICollection<TaggedBuffs> TaggedBuffs { get; set; }
        public virtual ICollection<TaggedItems> TaggedItems { get; set; }
        public virtual ICollection<TaggedNpcs> TaggedNpcs { get; set; }
        public virtual ICollection<TaggedSkills> TaggedSkills { get; set; }
        public virtual ICollection<TradegoodMaterials> TradegoodMaterials { get; set; }
        public virtual ICollection<ZoneGroupBannedTags> ZoneGroupBannedTags { get; set; }
    }
}
