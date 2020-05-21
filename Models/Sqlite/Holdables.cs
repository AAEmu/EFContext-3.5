using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Holdables
    {
        public Holdables()
        {
            ItemLookConvertHoldables = new HashSet<ItemLookConvertHoldables>();
            ItemRankAssignments = new HashSet<ItemRankAssignments>();
            ItemWeapons = new HashSet<ItemWeapons>();
        }

        public long Id { get; set; }
        public long? Angle { get; set; }
        public long? AnimL1Ratio { get; set; }
        public long? AnimL1Id { get; set; }
        public long? AnimL2Ratio { get; set; }
        public long? AnimL2Id { get; set; }
        public long? AnimL3Id { get; set; }
        public long? AnimR1Ratio { get; set; }
        public long? AnimR1Id { get; set; }
        public long? AnimR2Ratio { get; set; }
        public long? AnimR2Id { get; set; }
        public long? AnimR3Id { get; set; }
        public long? DamageScale { get; set; }
        public double? DurabilityRatio { get; set; }
        public long? EnchantedDps1000 { get; set; }
        public long? ExtraDamageBluntFactor { get; set; }
        public long? ExtraDamagePierceFactor { get; set; }
        public long? ExtraDamageSlashFactor { get; set; }
        public string FormulaArmor { get; set; }
        public string FormulaDps { get; set; }
        public string FormulaHdps { get; set; }
        public string FormulaMdps { get; set; }
        public long? GearScoreMultiplier { get; set; }
        public long? ItemProcId { get; set; }
        public long? MaxRange { get; set; }
        public long? MinRange { get; set; }
        public string Name { get; set; }
        public long? PoseId { get; set; }
        public long? RenewCategory { get; set; }
        public long? SheathePriority { get; set; }
        public long? SlotTypeId { get; set; }
        public long? SoundMaterialId { get; set; }
        public long? Speed { get; set; }
        public long? StatMultiplier { get; set; }

        public virtual ItemProcs ItemProc { get; set; }
        public virtual ICollection<ItemLookConvertHoldables> ItemLookConvertHoldables { get; set; }
        public virtual ICollection<ItemRankAssignments> ItemRankAssignments { get; set; }
        public virtual ICollection<ItemWeapons> ItemWeapons { get; set; }
    }
}
