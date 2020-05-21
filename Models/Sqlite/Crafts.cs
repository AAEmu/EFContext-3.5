using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Crafts
    {
        public Crafts()
        {
            CraftMaterials = new HashSet<CraftMaterials>();
            CraftPackCrafts = new HashSet<CraftPackCrafts>();
            CraftProducts = new HashSet<CraftProducts>();
            DoodadFuncCraftStartCrafts = new HashSet<DoodadFuncCraftStartCrafts>();
            ItemRecipes = new HashSet<ItemRecipes>();
            Items = new HashSet<ItemTemplate>();
            Moulds = new HashSet<Moulds>();
            QuestActObjCrafts = new HashSet<QuestActObjCrafts>();
            TrainCraftEffects = new HashSet<TrainCraftEffects>();
        }

        public long Id { get; set; }
        public long? AcId { get; set; }
        public long? ActabilityLimit { get; set; }
        public long? CastDelay { get; set; }
        public string Desc { get; set; }
        public byte[] NeedBind { get; set; }
        public long? ProductsPackId { get; set; }
        public long? RecommendLevel { get; set; }
        public long? ReqDoodadId { get; set; }
        public byte[] ShowUpperCrafts { get; set; }
        public long? SkillId { get; set; }
        public string Title { get; set; }
        public long? ToolId { get; set; }
        public byte[] UseOnlyActability { get; set; }
        public long? VisibleOrder { get; set; }
        public long? WiId { get; set; }

        public virtual Skills Skill { get; set; }
        public virtual ICollection<CraftMaterials> CraftMaterials { get; set; }
        public virtual ICollection<CraftPackCrafts> CraftPackCrafts { get; set; }
        public virtual ICollection<CraftProducts> CraftProducts { get; set; }
        public virtual ICollection<DoodadFuncCraftStartCrafts> DoodadFuncCraftStartCrafts { get; set; }
        public virtual ICollection<ItemRecipes> ItemRecipes { get; set; }
        public virtual ICollection<ItemTemplate> Items { get; set; }
        public virtual ICollection<Moulds> Moulds { get; set; }
        public virtual ICollection<QuestActObjCrafts> QuestActObjCrafts { get; set; }
        public virtual ICollection<TrainCraftEffects> TrainCraftEffects { get; set; }
    }
}
