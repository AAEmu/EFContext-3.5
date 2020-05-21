using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemGrades
    {
        public ItemGrades()
        {
            AccountAttendanceRewards = new HashSet<AccountAttendanceRewards>();
            ArmorGradeBuffs = new HashSet<ArmorGradeBuffs>();
            CraftProducts = new HashSet<CraftProducts>();
            HeroBonuses = new HashSet<HeroBonuses>();
            HeroRewards = new HashSet<HeroRewards>();
            ItemConvProducts = new HashSet<ItemConvProducts>();
            ItemConvReagentFilters = new HashSet<ItemConvReagentFilters>();
            ItemEnchantingGems = new HashSet<ItemEnchantingGems>();
            ItemGradeBuffs = new HashSet<ItemGradeBuffs>();
            ItemSlaveEquipmentGradeSpawns = new HashSet<ItemSlaveEquipmentGradeSpawns>();
            ItemSmeltingItems = new HashSet<ItemSmeltingItems>();
            RankRewards = new HashSet<RankRewards>();
        }

        public long Id { get; set; }
        public string ColorArgb { get; set; }
        public string ColorArgbSecond { get; set; }
        public double? DurabilityValue { get; set; }
        public long? GradeOrder { get; set; }
        public long? IconId { get; set; }
        public string Name { get; set; }
        public long? RefundMultiplier { get; set; }
        public long? StatMultiplier { get; set; }
        public long? UpgradeRatio { get; set; }
        public double? VarHoldableArmor { get; set; }
        public double? VarHoldableDps { get; set; }
        public double? VarHoldableHealDps { get; set; }
        public double? VarHoldableMagicDps { get; set; }
        public double? VarWearableArmor { get; set; }
        public double? VarWearableMagicResistance { get; set; }

        public virtual Icons Icon { get; set; }
        public virtual ICollection<AccountAttendanceRewards> AccountAttendanceRewards { get; set; }
        public virtual ICollection<ArmorGradeBuffs> ArmorGradeBuffs { get; set; }
        public virtual ICollection<CraftProducts> CraftProducts { get; set; }
        public virtual ICollection<HeroBonuses> HeroBonuses { get; set; }
        public virtual ICollection<HeroRewards> HeroRewards { get; set; }
        public virtual ICollection<ItemConvProducts> ItemConvProducts { get; set; }
        public virtual ICollection<ItemConvReagentFilters> ItemConvReagentFilters { get; set; }
        public virtual ICollection<ItemEnchantingGems> ItemEnchantingGems { get; set; }
        public virtual ICollection<ItemGradeBuffs> ItemGradeBuffs { get; set; }
        public virtual ICollection<ItemSlaveEquipmentGradeSpawns> ItemSlaveEquipmentGradeSpawns { get; set; }
        public virtual ICollection<ItemSmeltingItems> ItemSmeltingItems { get; set; }
        public virtual ICollection<RankRewards> RankRewards { get; set; }
    }
}
