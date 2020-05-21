using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemSets
    {
        public ItemSets()
        {
            DoodadFuncOneShotPlaces = new HashSet<DoodadFuncOneShotPlaces>();
            ItemSetItems = new HashSet<ItemSetItems>();
            ItemSmeltings = new HashSet<ItemSmeltings>();
            SkillEffects = new HashSet<SkillEffects>();
        }

        public long Id { get; set; }
        public long? KindId { get; set; }

        public virtual ICollection<DoodadFuncOneShotPlaces> DoodadFuncOneShotPlaces { get; set; }
        public virtual ICollection<ItemSetItems> ItemSetItems { get; set; }
        public virtual ICollection<ItemSmeltings> ItemSmeltings { get; set; }
        public virtual ICollection<SkillEffects> SkillEffects { get; set; }
    }
}
