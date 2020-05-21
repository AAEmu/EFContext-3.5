using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ActabilityGroups
    {
        public ActabilityGroups()
        {
            ActabilityViewGroupElems = new HashSet<ActabilityViewGroupElems>();
            DamageEffects = new HashSet<DamageEffects>();
            HealEffects = new HashSet<HealEffects>();
            HousingDecorations = new HashSet<HousingDecorations>();
            HousingRebuildings = new HashSet<HousingRebuildings>();
            Items = new HashSet<ItemTemplate>();
            QuestActObjLaborPowers = new HashSet<QuestActObjLaborPowers>();
            QuestActSupplyActabilities = new HashSet<QuestActSupplyActabilities>();
            Skills = new HashSet<Skills>();
        }

        public long Id { get; set; }
        public string IconPath { get; set; }
        public string Name { get; set; }
        public byte[] SkillPageVisible { get; set; }
        public long? UnitAttrId { get; set; }
        public byte[] Visible { get; set; }

        public virtual ICollection<ActabilityViewGroupElems> ActabilityViewGroupElems { get; set; }
        public virtual ICollection<DamageEffects> DamageEffects { get; set; }
        public virtual ICollection<HealEffects> HealEffects { get; set; }
        public virtual ICollection<HousingDecorations> HousingDecorations { get; set; }
        public virtual ICollection<HousingRebuildings> HousingRebuildings { get; set; }
        public virtual ICollection<ItemTemplate> Items { get; set; }
        public virtual ICollection<QuestActObjLaborPowers> QuestActObjLaborPowers { get; set; }
        public virtual ICollection<QuestActSupplyActabilities> QuestActSupplyActabilities { get; set; }
        public virtual ICollection<Skills> Skills { get; set; }
    }
}
